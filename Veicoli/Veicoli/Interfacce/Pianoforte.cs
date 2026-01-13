using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veicoli.Interfacce
{
    internal class Pianoforte(int AnnoDiProduzione, string Modello) : IFonteSonora
    {
        public int AnnoDiProduzione { get; set; } = AnnoDiProduzione;
        public string Modello { get; set; } = Modello;

        public string EmettiSuono()
        {
            return "DoReMiFaSol";
        }
    }
}
