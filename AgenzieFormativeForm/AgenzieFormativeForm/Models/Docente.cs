using System;

namespace AgenzieFormativeForm.Models
{
    public class Docente
    {
        public int Id { get; set; }
        public int AnagraficaId { get; set; }
        public int StatoCollaborazione { get; set; }
        public DateTime? DataAssunzione { get; set; }
        public DateTime DataInserimento { get; set; }
        public string? Categoria { get; set; }
    }
}
