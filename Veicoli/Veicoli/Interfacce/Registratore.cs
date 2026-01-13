using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veicoli.Interfacce
{
    internal class Registratore
    {
        public static void RegistraSuono(IFonteSonora fonteSonora)
        {
            Console.WriteLine(fonteSonora.EmettiSuono());
        }
    }
}
