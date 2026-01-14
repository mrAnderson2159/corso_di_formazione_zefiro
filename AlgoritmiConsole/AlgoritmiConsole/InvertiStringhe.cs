using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmiConsole
{
    internal class InvertiStringhe
    {
        public static string Inverti(string stringaDaInvertire)
        {
            string result = "";

            for (int i = stringaDaInvertire.Length - 1; i >= 0; i--)
            {
                result += stringaDaInvertire[i];
            }
            
            return result;
        }
    }
}
