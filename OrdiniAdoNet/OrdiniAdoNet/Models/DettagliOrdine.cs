using System;
using System.Collections.Generic;
using System.Text;

namespace OrdiniAdoNet.Models
{
    public class DettagliOrdine
    {
        public int Id { get; set; }
        public int OrdineId { get; set; }
        public int ProdottoId { get; set; }
        public int Quantita { get; set; }
        public decimal Prezzo { get; set; }
        public string Descrizione { get; set; }
        public void CopyFrom(DettagliOrdine other)
        {
            if (other == null) return;

            Id = other.Id;
            OrdineId = other.OrdineId;
            ProdottoId = other.ProdottoId;
            Quantita = other.Quantita;
            Prezzo = other.Prezzo;
            Descrizione = other.Descrizione;
        }
    }
}
