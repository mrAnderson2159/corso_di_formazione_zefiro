using System;
using System.Collections.Generic;
using System.Text;

namespace LibriAdoNet.Models
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public string? Categoria { get; set; }
        public int? NumeroPagine { get; set; }
        public DateTime? DataPubblicazione { get; set; }
        public bool? Esaurito { get; set; }
        public string? Fila {  get; set; }
        public string? Scaffale { get; set; }

        public string? InfoLibro { get
            {
                return $"{Titolo} - {Autore}";
            }
        }

        public void CopyTo(Libro other)
        {
            other.Id = Id;
            other.Titolo = Titolo;
            other.Autore = Autore;
            other.Categoria = Categoria;
            other.NumeroPagine = NumeroPagine;
            other.DataPubblicazione = DataPubblicazione;
            other.Esaurito = Esaurito;
            other.Fila = Fila;
            other.Scaffale = Scaffale;
        }
    }
}
