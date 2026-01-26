using Microsoft.Data.SqlClient;
using RubricaAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubricaAdoNet.DAO
{
    internal class ContattiRepository
    {
        public const string ATTRS = "Nome, Cognome, NumeroCellulare, NumeroFisso, Email, DataDiNascita, Citta";
        public const string ATTRS_PARAMS = "@nome, @cognome, @numeroCellulare, @numeroFisso, @email, @dataDiNascita, @citta";
        public const string CONTATTI = "Contatti";

        public static List<Contatto> GetAll()
        {
            string query = $"SELECT Id, {ATTRS} FROM {CONTATTI}"; 

            SqlDataReader reader = Dao.DAO.Read(query);

            return GetFromReader(reader);
        }

        public static bool Insert(Contatto contatto)
        {
            string query = $"INSERT INTO {CONTATTI} ({ATTRS}) VALUES ({ATTRS_PARAMS})";

            SqlParameter[] parameters =
            [
                new("nome", contatto.Nome),
                new("cognome", contatto.Cognome),
                new("numeroCellulare", contatto.NumeroCellulare),
                new("numeroFisso", contatto.NumeroFisso),
                new("email", contatto.Email),
                new("dataDiNascita", contatto.DataDiNascita),
                new("citta", contatto.Citta)
            ];

            int affected = Dao.DAO.Write(query, parameters);

            return affected > 0;
        }

        private static List<Contatto> GetFromReader(SqlDataReader reader)
        {
            List<Contatto> result = [];

            // SqlDataReader è uno stream di dati, si legge in maniera
            // squenziale, riga per riga fino a che ci sono
            // righe da leggare

            while (reader.Read())
            {
                Contatto contatto = new()
                {
                    Id = reader.GetInt32(0),
                    Nome = reader.GetString(1).Trim(),
                    Cognome = reader.GetString(2).Trim(),
                    NumeroCellulare = reader.IsDBNull(3) ? null : reader.GetString(3).Trim(),
                    NumeroFisso = reader.IsDBNull(4) ? null : reader.GetString(4).Trim(),
                    Email = reader.IsDBNull(5) ? null : reader.GetString(5).Trim(),
                    DataDiNascita = reader.IsDBNull(6) ? null : reader.GetDateTime(6),
                    Citta = reader.IsDBNull(7) ? null : reader.GetString(7).Trim()
                };

                result.Add(contatto);
            }
            // IMPORTANTE : chiudi il rider
            reader.Close();

            return result;
        }
    }
}
