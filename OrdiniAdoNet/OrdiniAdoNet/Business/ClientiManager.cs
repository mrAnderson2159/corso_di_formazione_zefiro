using Microsoft.Data.SqlClient;
using OrdiniAdoNet.DAO;
using OrdiniAdoNet.DTOs;
using OrdiniAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Text;

// Questa classe si occupa di accedere ai dati e mandarli verso la UI
namespace OrdiniAdoNet.Business
{
    internal class ClientiManager
    {
        private static readonly string _selectQuery = BuildSelectQuery();
        
        private static string BuildSelectQuery()
        {
            // Riprende gli attributi da ClientiRepository.ATTRS_WITH_ID facendoli precedere da "c."
            string cAttrs = string.Join(", ",
                ClientiRepository.ATTRS_WITH_ID
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(a => $"c.{a.Trim()}")
            );

            string subquery = """
                            SELECT
                                o.ClienteId AS ClienteId,
                                COUNT(*) AS OrdiniTotali,
                                SUM(do.Prezzo * do.Quantita) AS ImportoTotaleOrdinato,
                                MIN(o.DataOrdine) AS DataPrimoOrdine
                            FROM Ordini o
                            JOIN DettagliOrdini do ON o.ID = do.OrdineID
                            GROUP BY o.ClienteId
                            """;

                return $"""
                            SELECT
                                {cAttrs},
                                COALESCE(X.OrdiniTotali, 0) AS OrdiniTotali,
                                COALESCE(X.ImportoTotaleOrdinato, 0) AS ImportoTotaleOrdinato,
                                X.DataPrimoOrdine
                            FROM {ClientiRepository.TABLE_NAME} c
                            LEFT JOIN ({subquery}) AS X ON c.Id = X.ClienteId
                            """;
        }

        public static List<ClienteDTO> GetAll()
        {
            string query = $"{_selectQuery} " +
                $"WHERE c.Deleted = 0 " +
                $"ORDER BY c.Cognome, c.Nome";

            return GetFromReader(Dao.DAO.Read(query));
        }

        private static Cliente DTO_ToClient(ClienteDTO dto)
        {
            return new Cliente()
            {
                Id = dto.Id,
                Nome = dto.Nome,
                Cognome = dto.Cognome,
                CodiceFiscale = dto.CodiceFiscale,
                PartitaIva = dto.PartitaIva,
                Email = dto.Email,
                Telefono = dto.Telefono,
                Indirizzo = dto.Indirizzo,
                DataIscrizione = dto.DataIscrizione
            };
        }

        public static int? Insert(ClienteDTO dto)
        {
            Cliente cliente = DTO_ToClient(dto);
            return ClientiRepository.Insert(cliente);
        }

        public static bool Update(ClienteDTO dto)
        {
            Cliente cliente = DTO_ToClient(dto);
            return ClientiRepository.Update(cliente);
        }

        public static bool Delete(ClienteDTO dto)
        {
            Cliente cliente = DTO_ToClient(dto);
            return ClientiRepository.Delete(cliente);
        }

        public static bool CanDelete(ClienteDTO dto)
        {
            Cliente cliente = DTO_ToClient(dto);
            return ClientiRepository.CanDelete(cliente);
        }

        public static List<ClienteDTO> CercaPerNome(string filter)
        {
            string query = $"{_selectQuery} " +
                $"WHERE c.Deleted = 0 AND (c.Nome LIKE @filter OR c.Cognome LIKE @filter) " +
                $"ORDER BY c.Cognome, c.Nome";
            SqlParameter parameter = new("filter", $"%{filter}%");
            return GetFromReader(Dao.DAO.Read(query, parameter));
        }

        private static List<ClienteDTO> GetFromReader(SqlDataReader reader)
        {
            List<ClienteDTO> result = [];

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
                    DataIscrizione = reader.IsDBNull(8) ? null : reader.GetDateTime(8),
                    OrdiniTotali = reader.IsDBNull(9) ? null : reader.GetInt32(9),
                    ImportoTotaleOrdinato = reader.IsDBNull(10) ? null : reader.GetDecimal(10),
                    DataPrimoOrdine = reader.IsDBNull(11) ? null : reader.GetDateTime(11)
                });
            }

            reader.Close();
            return result;
        }
    }
}
