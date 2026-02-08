using System;

namespace AgenzieFormativeForm.Models
{
    public class Lezione
    {
        public int Id { get; set; }
        public int DocentiCorsiId { get; set; }
        public DateTime Data { get; set; }
        public string? Argomento { get; set; }
        public string Ufc { get; set; }
        public TimeSpan OrarioInizio { get; set; }
        public TimeSpan OrarioFine { get; set; }
        public string? Sede { get; set; }
        public bool Test { get; set; }
    }
}
