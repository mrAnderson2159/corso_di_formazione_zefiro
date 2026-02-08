using Microsoft.Data.SqlClient;
using OrdiniAdoNet.DAO;
using OrdiniAdoNet.DTOs;
using OrdiniAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrdiniAdoNet.Business
{
    internal class OrdiniManager
    {
        private const string ORDINI_ATTRS = "ClienteID, Numero, DataOrdine";
        private const string ORDINI_PARAMS = "@clienteId, @numero, @dataOrdine";
        private const string ORDINI_NAME = "Ordini";

        private static readonly string _selectQuery = """
            SELECT 
                o.Id, 
                o.ClienteID, 
                o.DataOrdine, 
                o.Numero, 
                c.Nome, 
                c.Cognome, 
                c.Indirizzo, 
                c.CodiceFiscale, 
                c.PartitaIVA 
            FROM Ordini o 
            JOIN Clienti c ON c.Id = o.ClienteID 
            """;

        public static List<OrdineDTO> GetAllOrdini()
        {
            // Mettere i campi Deleted serve a tenere traccia di ciò che è stato fatto
            string query = _selectQuery + """ 
                ORDER BY o.Numero, o.DataOrdine
                """;

            return GetDTO_OrdineFromReader(Dao.DAO.Read(query));
        }

        private static Ordine FromOrdineDTO_ToOrdine(OrdineDTO dto)
        {
            return new Ordine()
            {
                Id = dto.Id,
                Numero = dto.Numero,
                ClienteId = dto.ClienteId,
                DataOrdine = dto.DataOrdine
            };
        }

        public static int? InsertOrdine(OrdineDTO ordineDTO)
        {
            string query = $"INSERT INTO {ORDINI_NAME}({ORDINI_ATTRS}) VALUES ({ORDINI_PARAMS})";

            SqlParameter[] parameters = [
                new("clienteId", ordineDTO.ClienteId),
                new("numero", ordineDTO.Numero),
                new("dataOrdine", ordineDTO.DataOrdine)
             ];

            Dao.DAO.Write(query, parameters);
            return Dao.DAO.GetLastId();
        } 

        public static bool UpdateOrdine(OrdineDTO ordineDTO)
        {
            string query = $"""
                UPDATE {ORDINI_NAME} SET 
                    ClienteID = @clienteId,
                    Numero = @numero,
                    DataOrdine = @dataOrdine 
                WHERE Id = @id
                """;

            SqlParameter[] parameters = [
                new("clienteId", ordineDTO.ClienteId),
                new("numero", ordineDTO.Numero),
                new("dataOrdine", ordineDTO.DataOrdine),
                new("id", ordineDTO.Id)
            ];

            return Dao.DAO.Write(query, parameters) > 0;
        }

        public static List<OrdineDTO> GetDTO_OrdineFromReader(SqlDataReader reader)
        {
            List<OrdineDTO> result = [];

            while (reader.Read())
            {
                result.Add(new()
                {
                    Id = reader.GetInt32(0),
                    ClienteId = reader.GetInt32(1),
                    DataOrdine = reader.GetDateTime(2),
                    Numero = reader.GetString(3),
                    NomeCliente = reader.GetString(4),
                    CognomeCliente = reader.GetString(5),
                    IndirizzoCliente = reader.IsDBNull(6) ? null : reader.GetString(6),
                    CodiceFiscaleCliente = reader.IsDBNull(7) ? null : reader.GetString(7),
                    PartitaIVACliente = reader.IsDBNull(8) ? null : reader.GetString(8),
                });
            }

            reader.Close();
            return result;
        }
    }
}
