using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmiConsole
{
    internal class PariDispari
    {
        public static string VerificaNumero(int numero)
        {
            bool parita = numero % 2 == 0;
            return $"Il numero è {(parita ? "pari" : "dispari")}";
        }
    }
}
