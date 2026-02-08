using System;
using System.Collections.Generic;
using System.Text;

namespace OrdiniAdoNet.Models
{
    public class Prodotto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Prezzo { get; set; }
        public bool InStock { get; set; } = true;
        public string InfoProdotto { get => $"[{(InStock ? "Disponibile" : "Esaurito")}] - {Nome} - {Prezzo}€"; }

        public void CopyFrom(Prodotto other)
        {
            if (other == null) return;

            Id = other.Id;
            Nome = other.Nome;
            Prezzo = other.Prezzo;
            InStock = other.InStock;
        }

        public override string ToString()
        {
            return InfoProdotto;
        }
    }
}
