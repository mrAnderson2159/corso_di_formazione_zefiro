using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelForms.Models
{
    public class Contatto
    {
        public string Nome { get; set; } 
        public string Cognome { get; set; } 
        public string NumeroTelefono { get; set; }
        //il punto interrogativo serve a dire 
        //che quel dato può essere null
        public string? Email { get; set; }

        public string NomeCompleto { get => $"{Cognome} {Nome}"; }
    }
}
