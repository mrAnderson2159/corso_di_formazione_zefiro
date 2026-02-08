using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubricaAdoNet.DAO
{
    // Il DAO è sensibile al DBSM usato: per passare da un DBSM ad un altro
    // occorre cambiare le librerie usate dal DAO
    internal class Dao
    {
        // Il pattern SINGLETON serve a fare in modo che esista
        // una e una sola istanza viva di questa classe alla volta.
        // SINGLETON prevede una variabile statica dello stesso
        // tipo della classe privata
        private static Dao _dao;

        // Il secondo step per il pattern SINGLETON consiste nel retituire
        // una property statica che ritorna la variabile privata
        // e la istanzia solo se questo non è mai avvenuto prima
        public static Dao DAO
        {
            get
            {
                _dao ??= new Dao();
                return _dao;
            }
        }

        // Nessuno deve poter reistanziare/riassegnare una variabile
        // di un SINGLETON pattern, per cui serve un costruttore privato
        private Dao()
        {
            _sqlConnection = new SqlConnection(_connectionString);
            _sqlConnection.Open();
        }

        private readonly SqlConnection _sqlConnection;
        // SOLO A SCOPO DIDATTICO mettiamo qui una stringa che 
        // rappresenta la stringa di connessione
        // (la chiocciola serve ad evitare problemi con l'escape char "\")
        private const string _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Rubrica;Integrated Security=True";

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
                    // Il NULL del db è diverso dal null di C#, quindi va 
                    // convertito
                    foreach (SqlParameter param in parameters)
                    {
                        param.Value ??= DBNull.Value;
                    }
                }
                // AddRange espande l'array
                command.Parameters.AddRange(parameters);
            }

            newCommand = command;
        }

        // params è il varargs tipato
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
