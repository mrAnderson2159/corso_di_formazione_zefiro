using LibriAdoNet.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibriAdoNet.DAO
{
    internal class LibriRepository
    {
        public const string ATTRS = "Titolo, Autore, Categoria, NumeroPagine, DataPubblicazione, Esaurito, Fila, Scaffale";
        public const string ATTRS_PARAMS = "@titolo, @autore, @categoria, @numeroPagine, @dataPubblicazione, @esaurito, @fila, @scaffale";
        public const string LIBRI = "Libri";
        public const string ORDER = "ORDER BY Titolo";

        // RICORDA DI METTERE ID NELLE SELECT

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
            string query = $"SELECT Id, {ATTRS} FROM {LIBRI} {ORDER}";

            SqlDataReader reader = Dao.DAO.Read(query);

            return GetFromReader(reader);
        }


        public static int Insert(Libro libro)
        {
            string query = $"INSERT INTO {LIBRI} ({ATTRS}) VALUES ({ATTRS_PARAMS})";

            SqlParameter[] parameters =
            [
                new("titolo", libro.Titolo),
                new("autore", libro.Autore),
                new("categoria", libro.Categoria),
                new("numeroPagine", libro.NumeroPagine),
                new("dataPubblicazione", libro.DataPubblicazione),
                new("esaurito", libro.Esaurito),
                new("fila", libro.Fila),
                new("scaffale", libro.Scaffale)
            ];

            int affected = Dao.DAO.Write(query, parameters);
            int? lastId = Dao.DAO.GetLastId();

            return affected > 0 && lastId.HasValue ? (int)lastId : 0;
        }

        public static bool Update(Libro libro)
        {
            string query = $"UPDATE {LIBRI} SET " +
                $"Titolo = @titolo, " +
                $"Autore = @autore, " +
                $"Categoria = @categoria, " +
                $"NumeroPagine = @numeroPagine, " +
                $"DataPubblicazione = @dataPubblicazione, " +
                $"Esaurito = @esaurito, " +
                $"Fila = @fila, " +
                $"Scaffale = @scaffale " +
                $"WHERE Id = @id";

            SqlParameter[] parameters =
            [
                new("titolo", libro.Titolo),
                new("autore", libro.Autore),
                new("categoria", libro.Categoria),
                new("numeroPagine", libro.NumeroPagine),
                new("dataPubblicazione", libro.DataPubblicazione),
                new("esaurito", libro.Esaurito),
                new("fila", libro.Fila),
                new("scaffale", libro.Scaffale),
                new("id", libro.Id)
            ];

            int affected = Dao.DAO.Write(query, parameters);
            return affected > 0;
        }

        public static bool Delete(Libro libro)
        {
            string query = $"DELETE FROM {LIBRI} WHERE Id = @id";

            SqlParameter sqlParameter = new("id", libro.Id);

            int affected = Dao.DAO.Write(query, sqlParameter);

            return affected > 0;
        }

        public static List<Libro> SearchByTitle(string filtro)
        {
            string query = $"SELECT Id, {ATTRS} FROM {LIBRI} WHERE Titolo LIKE @filtro";

            SqlParameter parameter = new("filtro", $"%{filtro}%");

            SqlDataReader reader = Dao.DAO.Read(query, parameter);

            return GetFromReader(reader);
        }

        public static List<Libro> SearchByAuthor(string filtro)
        {
            string query = $"SELECT Id, {ATTRS} FROM {LIBRI} WHERE Autore LIKE @filtro";

            SqlParameter parameter = new("filtro", $"%{filtro}%");

            SqlDataReader reader = Dao.DAO.Read(query, parameter);

            return GetFromReader(reader);
        }
    }
}
