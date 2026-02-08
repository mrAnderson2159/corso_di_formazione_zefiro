using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportAdoNet.DAO
{
    internal class Dao
    {
        private static Dao _dao;

        public static Dao DAO
        {
            get
            {
                _dao ??= new Dao();
                return _dao;
            }
        }

        private Dao()
        {
            _sqlConnection = new SqlConnection(_connectionString);
            _sqlConnection.Open();
        }

        private readonly SqlConnection _sqlConnection;
        // SOLO A SCOPO DIDATTICO mettiamo qui una stringa che 
        // rappresenta la stringa di connessione
        // (la chiocciola serve ad evitare problemi con l'escape char "\")
        private const string _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Sport;Integrated Security=True";

        private void ResetConnectionIfNeeded()
        {
            if (_sqlConnection.State != System.Data.ConnectionState.Open)
            {
                _sqlConnection.Open();
            }
        }

        private void GetCommand(
            out SqlCommand newCommand,
            string query,
            bool convertNulls,
            params SqlParameter[] parameters
        )
        {
            ResetConnectionIfNeeded();

            SqlCommand command = _sqlConnection.CreateCommand();

            command.CommandText = query;

            if (parameters != null)
            {
                if (convertNulls)
                {
                    foreach (SqlParameter param in parameters)
                    {
                        param.Value ??= DBNull.Value;
                    }
                }
                command.Parameters.AddRange(parameters);
            }

            newCommand = command;
        }

        public SqlDataReader Read(string query, params SqlParameter[] parameters)
        {
            GetCommand(out SqlCommand command, query, convertNulls: false, parameters);
            return command.ExecuteReader();
        }

        public int Write(string query, params SqlParameter[] parameters)
        {
            GetCommand(out SqlCommand command, query, convertNulls: true, parameters);
            return command.ExecuteNonQuery();
        }

        public int? GetLastId()
        {
            SqlCommand command = _sqlConnection.CreateCommand();

            command.CommandText = "SELECT @@IDENTITY";
            object? result = command.ExecuteScalar();

            return result != DBNull.Value ? Convert.ToInt32(result) : null;
        }
    }
}
