using Microsoft.Data.SqlClient;
using SportAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportAdoNet.DAO
{
    internal class SportRepository
    {
        private const string ATTRS = "Nome, IsSportSquadra, Note";
        private const string ATTRS_WITH_ID = "Id, " + ATTRS;
        private const string PARAMS = "@nome, @isSportSquadra, @note";
        private const string TABLE_NAME = "Sport";

        public static List<Sport> GetAll()
        {
            string query = $"SELECT {ATTRS_WITH_ID} FROM {TABLE_NAME}";
            SqlDataReader reader = Dao.DAO.Read(query);
            return GetFromReader(reader);
        }

        public static int? Insert(Sport sport)
        {
            string query = $"INSERT INTO {TABLE_NAME} ({ATTRS}) VALUES ({PARAMS})";

            SqlParameter[] parameters = [
                new("nome", sport.Nome),
                new("isSportSquadra", sport.IsSportSquadra),
                new("note", sport.Note)
            ];

            Dao.DAO.Write(query, parameters);
            return Dao.DAO.GetLastId();
        }

        public static bool Update(Sport sport)
        {
            string query = "UPDATE Sport SET " +
                "Nome = @nome, " +
                "IsSportSquadra = @isSportSquadra, " +
                "Note = @note " +
                "WHERE Id = @id";

            SqlParameter[] parameters = [
                new SqlParameter("nome", sport.Nome),
                new SqlParameter("isSportSquadra", sport.IsSportSquadra),
                new SqlParameter("note", sport.Note),
                new SqlParameter("id", sport.Id)
            ];

            int righe = Dao.DAO.Write(query, parameters);
            return righe > 0;
        }

        public static bool Delete(Sport sport)
        {
            string query = $"DELETE FROM {TABLE_NAME} WHERE Id = @id";
            SqlParameter parameter = new("id", sport.Id); 
            int righe = Dao.DAO.Write(query, parameter);
            return righe > 0;
        }

        private static List<Sport> GetFromReader(SqlDataReader reader)
        {
            List<Sport> result = [];

            while (reader.Read())
            {
                Sport sport = new()
                {
                    Id = reader.GetInt32(0),
                    Nome = reader.GetString(1).Trim(),
                    IsSportSquadra = reader.IsDBNull(2) ? null : reader.GetBoolean(2),
                    Note = reader.IsDBNull(3) ? null : reader.GetString(3).Trim()
                };
                result.Add(sport);
            }

            reader.Close();

            return result;
        }
    }
}
