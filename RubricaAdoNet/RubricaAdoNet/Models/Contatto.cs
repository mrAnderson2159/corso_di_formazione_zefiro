using System;
using System.Collections.Generic;
using System.Text;

namespace RubricaAdoNet.Models
{
    public class Contatto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string? NumeroCellulare { get; set; }
        public string? NumeroFisso { get; set; }
        public string? Email { get; set; }
        public string? Citta { get; set; }
        public DateTime? DataDiNascita { get; set; }
        public string InfoContatto { get => $"Id {Id} - {Nome} {Cognome}"; }

        public void CloneTo(Contatto clone)
        {
            clone.Id = Id;
            clone.Nome = Nome;
            clone.Cognome = Cognome;
            clone.NumeroCellulare = NumeroCellulare;
            clone.NumeroFisso = NumeroFisso;
            clone.Email = Email;
            clone.Citta = Citta;
        }

        public void CloneFrom(Contatto image)
        {
            Id = image.Id;
            Nome = image.Nome;
            Cognome = image.Cognome;
            NumeroCellulare = image.NumeroCellulare;
            NumeroFisso = image.NumeroFisso;
            Email = image.Email;
            Citta = image.Citta;
        }
    }
}
