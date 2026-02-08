using System;

namespace AgenzieFormativeForm.Models
{
    public class Iscrizione
    {
        public int Id { get; set; }
        public int StudenteId { get; set; }
        public int CorsoId { get; set; }
        public DateTime DataIscrizione { get; set; }
        public bool Ritirato { get; set; }
        public DateTime? DataRitiro { get; set; }
        public decimal? CostoIscrizione { get; set; }
    }
}
