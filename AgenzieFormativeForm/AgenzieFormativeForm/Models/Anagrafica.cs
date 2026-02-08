using System;

namespace AgenzieFormativeForm.Models
{
    public class Anagrafica
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string? CodiceFiscale { get; set; }
        public DateTime DataNascita { get; set; }
        public string? IndirizzoResidenza { get; set; }
        public string? CittaResidenza { get; set; }
        public string? NumeroTelefono { get; set; }
        public string? Email { get; set; }
        public string? Pec { get; set; }
        public string? Sesso { get; set; }
    }
}
