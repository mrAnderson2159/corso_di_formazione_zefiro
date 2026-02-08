using System;

namespace AgenzieFormativeForm.Models
{
    public class Corso
    {
        public int Id { get; set; }
        public string Titolo { get; set; }
        public int TotaleOre { get; set; }
        public bool Finanziato { get; set; }
        public string? EnteFinanziatore { get; set; }
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }
        public DateTime DataEsame { get; set; }
        public int ModalitaErogazione { get; set; }
    }
}
