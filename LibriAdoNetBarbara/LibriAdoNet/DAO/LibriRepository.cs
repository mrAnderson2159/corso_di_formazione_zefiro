using LibriAdoNet.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibriAdoNet.DAO
{
    internal class LibriRepository
    {
        private static List<Libro> GetFromReader(SqlDataReader reader)
        {
            List<Libro> result = [];

            while (reader.Read())
            {
                result.Add(
                    new()
                    {
                        Id = reader.GetInt32(0),
                        Titolo = reader.GetString(1).Trim(),
                        Autore = reader.GetString(2).Trim(),
                        Categoria = reader.IsDBNull(3) ? null : reader.GetString(3).Trim(),
                        NumeroPagine = reader.IsDBNull(4) ? null : reader.GetInt32(4),
                        DataPubblicazione = reader.IsDBNull(5) ? null : reader.GetDateTime(5),
                        Esaurito = reader.IsDBNull(6) ? null : reader.GetBoolean(6),
                        Fila = reader.IsDBNull(7) ? null : reader.GetString(7).Trim(),
                        Scaffale = reader.IsDBNull(8) ? null : reader.GetString(8).Trim(),
                    }
                );
            }

            reader.Close();

            return result;
        }

        public static List<Libro> GetAll()
        {
            string query = $"SELECT Id, Titolo, Autore, Categoria, NumeroPagine, DataPubblicazione, " +
                $"Esaurito, Fila, Scaffale FROM Libri ORDER BY Titolo";

            SqlDataReader reader = Dao.DAO.Read(query);

            return GetFromReader(reader);
        }
    }
}
