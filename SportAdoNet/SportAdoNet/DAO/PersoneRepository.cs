using Microsoft.Data.SqlClient;
using SportAdoNet.Models;
using System.Collections.Generic;
using System.Text;

namespace SportAdoNet.DAO
{
    internal class PersoneRepository
    {
        private const string ATTRS = "Nome, Cognome, CodiceFiscale, DataNascita, IdSport, InfoContatto";
        private const string ATTRS_WITH_ID = "Id, " + ATTRS;
        private const string PARAMS = "@nome, @cognome, @codiceFiscale, @dataNascita, @idSport, @infoContatto";
        private const string TABLE_NAME = "Persone";
        private const string ORDER = "ORDER BY Cognome, Nome";

        public static List<Persona> GetAll()
        {
            string query = $"SELECT {ATTRS_WITH_ID} FROM {TABLE_NAME} {ORDER}";
            SqlDataReader reader = Dao.DAO.Read(query);
            return GetFromReader(reader);
        }

        public static int? Insert(Persona persona)
        {
            string query = $"INSERT INTO {TABLE_NAME} ({ATTRS}) VALUES ({PARAMS})";
            SqlParameter[] parameters = [
                new("nome", persona.Nome),
                new("cognome", persona.Cognome),
                new("codiceFiscale", persona.CodiceFiscale),
                new("dataNascita", persona.DataNascita),
                new("idSport", persona.IdSport),
                new("infoContatto", persona.InfoContatto)
            ];
            Dao.DAO.Write(query, parameters);
            return Dao.DAO.GetLastId();
        }

        public static bool Update(Persona persona)
        {
            string query = "UPDATE Persone SET " +
                "Nome = @nome, " +
                "Cognome = @cognome, " +
                "CodiceFiscale = @codiceFiscale, " +
                "DataNascita = @dataNascita, " +
                "IdSport = @idSport, " +
                "InfoContatto = @infoContatto " +
                "WHERE Id = @id";

            SqlParameter[] parameters = [
                new("nome", persona.Nome),
                new("cognome", persona.Cognome),
                new("codiceFiscale", persona.CodiceFiscale),
                new("dataNascita", persona.DataNascita),
                new("idSport", persona.IdSport),
                new("infoContatto", persona.InfoContatto),
                new("id", persona.Id)
            ];

            int affected = Dao.DAO.Write(query, parameters);
            return affected > 0;
        }

        public static bool Delete(Persona persona)
        {
            string query = $"DELETE FROM {TABLE_NAME} WHERE Id = @id";
            SqlParameter parameter = new("id", persona.Id);
            int affected = Dao.DAO.Write(query, parameter);
            return affected > 0;
        }

        public static List<Persona> GetBySport(int id)
        {
            string query = $"SELECT {ATTRS_WITH_ID} FROM {TABLE_NAME} WHERE " +
                $"(@idSport = 0 AND IdSport IS NULL) OR " +
                $"(@idSport = -1 AND IdSport IS NOT NULL) OR " +
                $"(@idSport = -2) OR " +
                $"(@idSport > 0 AND IdSport = @idSport)";

            SqlParameter parameter = new("idSport", id);

            return GetFromReader(Dao.DAO.Read(query, parameter));
        }

        private static List<Persona> GetFromReader(SqlDataReader reader)
        {
            List<Persona> result = [];

            while (reader.Read())
            {
                Persona persona = new()
                {
                    Id = reader.GetInt32(0),
                    Nome = reader.GetString(1).Trim(),
                    Cognome = reader.GetString(2).Trim(),
                    CodiceFiscale = reader.IsDBNull(3) ? null : reader.GetString(3).Trim(),
                    DataNascita = reader.GetDateTime(4),
                    IdSport = reader.IsDBNull(5) ? null : reader.GetInt32(5),
                    InfoContatto = reader.IsDBNull(6) ? null : reader.GetString(6).Trim()
                };
                result.Add(persona);
            }
            reader.Close();

            return result;
        }
    }
}
