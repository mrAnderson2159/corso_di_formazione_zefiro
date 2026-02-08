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
        public string InfoLibro { get => $"{Titolo} - {Autore}"; }
        public string FullInfoLibro { get => $"{Titolo} - {Autore} {(Esaurito != null && (bool)Esaurito ? "- Esaurito": "")}".Trim(); }

        public void CopyFrom(Libro other)
        {
            Id = other.Id;
            Titolo = other.Titolo;
            Autore = other.Autore;
            Categoria = other.Categoria;
            NumeroPagine = other.NumeroPagine;
            DataPubblicazione = other.DataPubblicazione;
            Esaurito = other.Esaurito;
            Fila = other.Fila;
            Scaffale = other.Scaffale;
        }
    }
}
