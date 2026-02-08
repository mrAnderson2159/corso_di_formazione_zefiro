using System;
using System.Collections.Generic;
using System.Text;

namespace OrdiniAdoNet.DTOs
{
    public class OrdineDTO
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public DateTime DataOrdine { get; set; } = DateTime.Today;
        public string Numero { get; set; }

        public string NomeCliente { get; set; }
        public string CognomeCliente { get; set; }
        public string? IndirizzoCliente { get; set; }
        public string? CodiceFiscaleCliente { get; set; }
        public string? PartitaIVACliente { get; set; }

        public void CopyFrom(OrdineDTO source)
        {
            Id = source.Id;
            ClienteId = source.ClienteId;
            DataOrdine = source.DataOrdine;
            Numero = source.Numero;
            NomeCliente = source.NomeCliente;
            CognomeCliente = source.CognomeCliente;
            IndirizzoCliente = source.IndirizzoCliente;
            CodiceFiscaleCliente = source.CodiceFiscaleCliente;
            PartitaIVACliente = source.PartitaIVACliente;
        }
    }
}
