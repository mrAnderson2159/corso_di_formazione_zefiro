using OrdiniAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrdiniAdoNet.DTOs
{
    public class ProdottoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Prezzo { get; set; }
        public bool InStock { get; set; } = true;
        public string InfoProdotto { get => $"[{(InStock ? "Disponibile" : "Esaurito")}] - {Nome} - {Prezzo}€"; }

        // quantità totale ordinata e importo totale ordinato
        public int? QuantitaTotaleOrdinata { get; set; }
        public decimal? ImportoTotaleOrdinato { get; set; }

        public void CopyFrom(ProdottoDTO other)
        {
            if (other == null) return;

            Id = other.Id;
            Nome = other.Nome;
            Prezzo = other.Prezzo;
            InStock = other.InStock;
            QuantitaTotaleOrdinata = other.QuantitaTotaleOrdinata;
            ImportoTotaleOrdinato = other.ImportoTotaleOrdinato;
        }

        public override string ToString()
        {
            return InfoProdotto;
        }
    }
}
