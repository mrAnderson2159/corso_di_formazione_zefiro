using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmiConsole
{
    internal class Prodotto
    {
        public static string Moltiplica(string? numeroString1, string? numeroString2)
        {
            if (Int32.TryParse(numeroString1, out int numero1) && Int32.TryParse(numeroString2, out int numero2))
            {
                int prodotto = numero1 * numero2;
                return prodotto.ToString();
            }

            return "Devi inserire due numeri validi";
        }
    }
}
