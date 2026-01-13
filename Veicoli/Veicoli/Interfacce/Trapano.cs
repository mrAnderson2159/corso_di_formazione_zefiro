using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veicoli.Interfacce
{
    internal class Trapano(string Marca, string Modello) : IFonteSonora
    {   
        public string Marca { get; set; } = Marca;
        public string Modello { get; set; } = Modello;

        public string EmettiSuono()
        {
            return "TRRRRR";
        }
    }
}
