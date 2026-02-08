using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrdiniAdoNet.Models
{
    public class Cliente
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

        public void CopyFrom(Cliente other)
        {
            if (other == null) return;

            Id = other.Id;
            Nome = other.Nome;
            Cognome = other.Cognome;
            CodiceFiscale = other.CodiceFiscale;
            PartitaIva = other.PartitaIva;
            Email = other.Email;
            Telefono = other.Telefono;
            Indirizzo = other.Indirizzo;
            DataIscrizione = other.DataIscrizione;
        }

        public override string ToString()
        {
            return InfoCliente;
        }
    }
}
