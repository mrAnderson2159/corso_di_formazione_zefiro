using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportAdoNet.Models
{
    public class Sport
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool? IsSportSquadra { get; set; }
        public string? Note { get; set; }
        public string InfoSport { get => $"{Id} - {Nome}"; }

        public void CopyFrom(Sport other)
        {
            Id = other.Id;
            Nome = other.Nome;
            IsSportSquadra = other.IsSportSquadra;
            Note = other.Note;
        }
    }
}
