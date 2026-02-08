using System;
using System.Collections.Generic;
using System.Text;

namespace OrdiniAdoNet.Models
{
    public class Ordine
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public DateTime DataOrdine { get; set; }
        public string Numero { get; set; }

        public void CopyFrom(Ordine other)
        {
            if (other == null) return;

            Id = other.Id;
            ClienteId = other.ClienteId;
            DataOrdine = other.DataOrdine;
            Numero = other.Numero;
        }
    }
}
