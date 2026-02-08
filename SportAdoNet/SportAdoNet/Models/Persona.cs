using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportAdoNet.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string? CodiceFiscale { get; set; }
        public DateTime DataNascita { get; set; }
        public string? InfoContatto { get; set; }
        public int? IdSport { get; set; }
        public string InfoPersona { get => $"{Cognome} {Nome}"; }

        public void CopyFrom(Persona other)
        {
            Id = other.Id;
            Nome = other.Nome;
            Cognome = other.Cognome;
            CodiceFiscale = other.CodiceFiscale;
            DataNascita = other.DataNascita;
            InfoContatto = other.InfoContatto;
            IdSport = other.IdSport;
        }
    }
}
