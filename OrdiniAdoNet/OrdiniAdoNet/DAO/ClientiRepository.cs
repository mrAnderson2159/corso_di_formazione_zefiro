using Microsoft.Data.SqlClient;
using OrdiniAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrdiniAdoNet.DAO
{
    internal class ClientiRepository
    {
        public const string ATTRS = "Nome, Cognome, CodiceFiscale, PartitaIVA, Email, Telefono, Indirizzo, DataRegistrazione";
        public const string ATTRS_WITH_ID = "Id, " + ATTRS;
        public const string ATTRS_PARAMS = "@nome, @cognome, @codiceFiscale, @partitaIVA, @email, @telefono, @indirizzo, @dataRegistrazione";
        public const string TABLE_NAME = "Clienti";

        public static List<Cliente> GetAll()
        {
            string query = $"SELECT {ATTRS_WITH_ID} FROM {TABLE_NAME} WHERE Deleted = 0";
            return GetFromReader(Dao.DAO.Read(query));
        }

        public static int? Insert(Cliente cliente)
        {
            string query = $"INSERT INTO {TABLE_NAME} ({ATTRS}) VALUES ({ATTRS_PARAMS})";
            SqlParameter[] parameters =
            [
                new("@nome", cliente.Nome),
                new("@cognome", cliente.Cognome),
                new("@codiceFiscale", cliente.CodiceFiscale),
                new("@partitaIVA", cliente.PartitaIva),
                new("@email", cliente.Email),
                new("@telefono", cliente.Telefono),
                new("@indirizzo", cliente.Indirizzo),
                new("@dataRegistrazione", cliente.DataIscrizione)
            ];

            Dao.DAO.Write(query, parameters);
            return Dao.DAO.GetLastId();
        }

        public static bool Update(Cliente cliente)
        {
            string query = $"UPDATE {TABLE_NAME} SET " +
                           $"Nome = @nome, " +
                           $"Cognome = @cognome, " +
                           $"CodiceFiscale = @codiceFiscale, " +
                           $"PartitaIVA = @partitaIVA, " +
                           $"Email = @email, " +
                           $"Telefono = @telefono, " +
                           $"Indirizzo = @indirizzo, " +
                           $"DataRegistrazione = @dataRegistrazione " +
                           $"WHERE Id = @id";
            SqlParameter[] parameters =
            [
                new("@nome", cliente.Nome),
                new("@cognome", cliente.Cognome),
                new("@codiceFiscale", cliente.CodiceFiscale),
                new("@partitaIVA", cliente.PartitaIva),
                new("@email", cliente.Email),
                new("@telefono", cliente.Telefono),
                new("@indirizzo", cliente.Indirizzo),
                new("@dataRegistrazione", cliente.DataIscrizione),
                new("@id", cliente.Id)
            ];

            return Dao.DAO.Write(query, parameters) > 0;
        }

        public static bool Delete(Cliente cliente)
        {
            string query = $"UPDATE {TABLE_NAME} SET Deleted = 1 WHERE Id = @id";
            SqlParameter parameter = new("@id", cliente.Id);
            return Dao.DAO.Write(query, parameter) > 0;
        }

        public static bool CanDelete(Cliente cliente)
        {
            string query = "SELECT COUNT(*) FROM Ordini WHERE ClienteId = @id";
            SqlParameter parameter = new("id", cliente.Id);

            if (Dao.DAO.Scalar(query, parameter) is int ordini)
            {
                return ordini == 0;
            }

            throw new InvalidOperationException(
                $"Stato del database non valido: il conteggio degli ordini associati al cliente con ID {cliente.Id} " +
                "ha restituito un valore nullo, violando un'invariante del sistema."
            );
        }

        public static List<Cliente> CercaPerNome(string filter)
        {
            string query = $"SELECT {ATTRS_WITH_ID} FROM {TABLE_NAME} WHERE Nome LIKE @filter OR Cognome LIKE @filter";
            SqlParameter parameter = new("filter", $"%{filter}%");
            return GetFromReader(Dao.DAO.Read(query, parameter));
        }

        private static List<Cliente> GetFromReader(SqlDataReader reader)
        {
            List<Cliente> result = [];

            while (reader.Read())
            {
                result.Add(new()
                {
                    Id = reader.GetInt32(0),
                    Nome = reader.GetString(1).Trim(),
                    Cognome = reader.GetString(2).Trim(),
                    CodiceFiscale = reader.IsDBNull(3) ? null : reader.GetString(3).Trim(),
                    PartitaIva = reader.IsDBNull(4) ? null : reader.GetString(4).Trim(),
                    Email = reader.IsDBNull(5) ? null : reader.GetString(5).Trim(),
                    Telefono = reader.IsDBNull(6) ? null : reader.GetString(6).Trim(),
                    Indirizzo = reader.IsDBNull(7) ? null : reader.GetString(7).Trim(),
                    DataIscrizione = reader.IsDBNull(8) ? null : reader.GetDateTime(8)
                });
            }

            reader.Close();
            return result;
        }
    }
}
