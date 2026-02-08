using Microsoft.Data.SqlClient;
using OrdiniAdoNet.DAO;
using OrdiniAdoNet.DTOs;
using OrdiniAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrdiniAdoNet.Business
{
    internal class ProdottiManager
    {
        private static readonly string _selectQuery = BuildSelectQuery();

        private static string BuildSelectQuery()
        {
            // Riprende gli attributi da ProdottiRepository.ATTRS_WITH_ID facendoli precedere da "p."
            string pAttrs = string.Join(", ",
                ProdottiRepository.ATTRS_WITH_ID
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => "p." + x.Trim())
             );

            return $"""
                SELECT {pAttrs}, COUNT(p.Id) AS QuantitaTotaleOrdinata, SUM(do.Prezzo) AS ImportoTotaleOrdinato
                FROM Prodotti p
                LEFT JOIN DettagliOrdini do ON do.ProdottoID = p.Id
                WHERE p.Deleted = 0
                GROUP BY {pAttrs}
                """;
        }

        private static Prodotto ProdottoDTO_ToProdotto(ProdottoDTO dto)
        {
            return new Prodotto()
            {
                Id = dto.Id,
                Nome = dto.Nome,
                Prezzo = dto.Prezzo,
                InStock = dto.InStock
            };
        }

        public static List<ProdottoDTO> GetAll()
        {
            string query = _selectQuery + " " +
                "ORDER BY p.Nome";

            System.Diagnostics.Debug.WriteLine(query);
            return GetFromReader(Dao.DAO.Read(query));
        }

        public static int? Insert(ProdottoDTO prodottoDTO)
        {
            Prodotto prodotto = ProdottoDTO_ToProdotto(prodottoDTO);
            return ProdottiRepository.Insert(prodotto);
        }

        public static bool Update(ProdottoDTO prodottoDTO)
        {
            Prodotto prodotto = ProdottoDTO_ToProdotto(prodottoDTO);
            return ProdottiRepository.Update(prodotto);
        }

        public static bool? Delete(ProdottoDTO prodottoDTO)
        {
            Prodotto prodotto = ProdottoDTO_ToProdotto(prodottoDTO);
            return ProdottiRepository.Delete(prodotto);
        }

        public static bool CanDelete(ProdottoDTO prodottoDTO)
        {
            Prodotto prodotto = ProdottoDTO_ToProdotto(prodottoDTO);
            return ProdottiRepository.CanDelete(prodotto);
        }

        public static List<ProdottoDTO> CercaPerNome(string filter)
        {
            string query = _selectQuery + " " +
                "HAVING p.Nome LIKE @filter " +
                "ORDER BY p.Nome";
            SqlParameter parameter = new("filter", $"%{filter}%");
            return GetFromReader(Dao.DAO.Read(query, parameter));
        }

        private static List<ProdottoDTO> GetFromReader(SqlDataReader reader)
        {
            List<ProdottoDTO> result = [];
            
            while (reader.Read())
            {
                result.Add(new()
                {
                    Id = reader.GetInt32(0),
                    Nome = reader.GetString(1),
                    Prezzo = reader.GetDecimal(2),
                    InStock = reader.GetBoolean(3),
                    QuantitaTotaleOrdinata = reader.IsDBNull(4) ? 0 : reader.GetInt32(4),
                    ImportoTotaleOrdinato = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5),
                });
            }

            reader.Close();
            return result;
        }
    }
}
