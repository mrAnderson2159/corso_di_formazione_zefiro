using System;

namespace AgenzieFormativeForm.Models
{
    public class Studente
    {
        public int Id { get; set; }
        public int AnagraficaId { get; set; }
        public string Matricola { get; set; }
        public DateTime DataInserimento { get; set; }
        public int StatoOccupazionale { get; set; }
    }
}
