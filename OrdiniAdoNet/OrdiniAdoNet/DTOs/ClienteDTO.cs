using System;
using System.Collections.Generic;
using System.Text;

namespace OrdiniAdoNet.DTOs
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string? CodiceFiscale { get; set; }
        public string? PartitaIva { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }
        public string? Indirizzo { get; set; }
        public DateTime? DataIscrizione { get; set; }
        public string InfoCliente { get => $"{Cognome} {Nome}"; }

        public int? OrdiniTotali { get; set; }
        public decimal? ImportoTotaleOrdinato { get; set; }
        public DateTime? DataPrimoOrdine { get; set; }

        public void CopyFrom(ClienteDTO other)
        {
            Id = other.Id;
            Nome = other.Nome;
            Cognome = other.Cognome;
            CodiceFiscale = other.CodiceFiscale;
            PartitaIva = other.PartitaIva;
            Email = other.Email;
            Telefono = other.Telefono;
            Indirizzo = other.Indirizzo;
            DataIscrizione = other.DataIscrizione;
            OrdiniTotali = other.OrdiniTotali;
            ImportoTotaleOrdinato = other.ImportoTotaleOrdinato;
            DataPrimoOrdine = other.DataPrimoOrdine;
        }

        public override string ToString()
        {
            return InfoCliente;
        }
    }
}
