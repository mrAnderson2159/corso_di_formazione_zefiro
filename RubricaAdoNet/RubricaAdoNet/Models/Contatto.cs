using System;
using System.Collections.Generic;
using System.Text;

namespace RubricaAdoNet.Models
{
    public class Contatto
    {
        public required int Id { get; set; }
        public required string Nome { get; set; }
        public required string Cognome { get; set; }
        public string? NumeroCellulare { get; set; }
        public string? NumeroFisso { get; set; }
        public string? Email { get; set; }
        public string? Citta { get; set; }
        public DateTime? DataDiNascita { get; set; }
    }
}
