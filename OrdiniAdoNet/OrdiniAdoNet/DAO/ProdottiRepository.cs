using Microsoft.Data.SqlClient;
using OrdiniAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrdiniAdoNet.DAO
{
    internal class ProdottiRepository
    {
        public const string ATTRS = "Nome, Prezzo, InStock";
        public const string ATTRS_WITH_ID = "Id, " + ATTRS;
        public const string ATTRS_PARAM = "@Nome, @Prezzo, @InStock";
        public const string TABLE_NAME = "Prodotti";

        public static List<Prodotto> GetAll()
        {
            string query = $"SELECT {ATTRS_WITH_ID} FROM {TABLE_NAME} WHERE Deleted = 0";
            return GetFromReader(Dao.DAO.Read(query));
        }

        public static int? Insert(Prodotto prodotto)
        {
            string query = $"INSERT INTO {TABLE_NAME} ({ATTRS}) VALUES ({ATTRS_PARAM})";
            SqlParameter[] parameters =
            [
                new("@Nome", prodotto.Nome),
                new("@Prezzo", prodotto.Prezzo),
                new("@InStock", prodotto.InStock)
            ];

            Dao.DAO.Write(query, parameters);
            return Dao.DAO.GetLastId();
        }

        public static bool Update(Prodotto prodotto)
        {
            string query = $"UPDATE {TABLE_NAME} SET " +
                           $"Nome = @Nome, " +
                           $"Prezzo = @Prezzo, " +
                           $"InStock = @InStock " +
                           $"WHERE Id = @Id";
            SqlParameter[] parameters =
            [
                new("@Nome", prodotto.Nome),
                new("@Prezzo", prodotto.Prezzo),
                new("@InStock", prodotto.InStock),
                new("@Id", prodotto.Id)
            ];

            return Dao.DAO.Write(query, parameters) > 0;
        }

        public static bool? Delete(Prodotto prodotto)
        {
            string query = $"UPDATE {TABLE_NAME} SET Deleted = 1 WHERE Id = @id";
            SqlParameter parameter = new("@id", prodotto.Id);
            return Dao.DAO.Write(query, parameter) > 0;
        }

        public static bool CanDelete(Prodotto prodotto)
        {
            string query = "SELECT COUNT(*) FROM DettagliOrdini WHERE ProdottoId = @id";
            SqlParameter parameter = new("@id", prodotto.Id);
            
            if (Dao.DAO.Scalar(query, parameter) is int count)
            {
                return count == 0;
            }

            throw new InvalidOperationException($"Stato del database non valido: il conteggio degli ordini associati al prodotto " +
                $"con id {prodotto.Id} ha restituito un valore nullo, violando un'invariante del sistema.");
        }

        public static List<Prodotto> CercaPerNome(string filter)
        {
            string query = $"SELECT {ATTRS_WITH_ID} FROM {TABLE_NAME} WHERE Nome LIKE @filter";
            SqlParameter parameter = new("filter", $"%{filter}%");
            return GetFromReader(Dao.DAO.Read(query, parameter));
        }

        private static List<Prodotto> GetFromReader(SqlDataReader reader)
        {
            List<Prodotto> result = [];

            while (reader.Read())
            {
                result.Add(new()
                {
                    Id = reader.GetInt32(0),
                    Nome = reader.GetString(1).Trim(),
                    Prezzo = reader.GetDecimal(2),
                    InStock = reader.GetBoolean(3)
                });
            }

            reader.Close();
            return result;
        }
    }
}
