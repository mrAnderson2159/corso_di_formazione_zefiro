using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmiConsole
{
    internal class OperazioniNumeriche
    {
        public static int Min(int[] numeri)
        {
            if (numeri.Length == 0)
            { 
                return 0; 
            }

            int min = numeri[0];

            for (int i = 1; i < numeri.Length; i++)
            {
                if (numeri[i] < min)
                {
                    min = numeri[i];
                }
            }
                
            
            return min;
        }

        public static int Max(int[] numeri)
        {
            if (numeri.Length == 0)
            {
                return 0;
            }

            int max = numeri[0];

            for (int i = 1; i < numeri.Length; i++)
            {
                if (numeri[i] > max)
                {
                    max = numeri[i];
                }
            }

            return max;
        }

        public static int SommaPari(int[] numeri)
        {
            int result = 0;

            for (int i = 0; i < numeri.Length; i++)
            {
                if (numeri[i] % 2 == 0)
                {
                    result += numeri[i];
                }
            }

            return result;
        }

        public static int SommaDispari(int[] numeri)
        {
            int result = 0;

            foreach (int n in numeri)
            {
                if ((n % 2) == 1)
                {
                    result += n; 
                }
            }

            return result;
        }

        public static int Somma(int[] numeri)
        {
            int result = 0;

            foreach (int n in numeri)
            {
                result += n;
            }

            return result;
        }

        public static int Medio(int[] numeri)
        {
            int min = Min(numeri);
            int max = Max(numeri);

            int media = (min + max) / 2;
            int diff = Int32.MaxValue;
            int result = 0;

            foreach (int n in numeri)
            {
                int diffNumero = Math.Abs(media - n);

                if (diffNumero < diff)
                {
                    diff = diffNumero;
                    result = n;
                }
            }

            return result;
        }

        public static int ContaVocali(string frase)
        {
            frase = frase.ToLower();
            int contatore = 0;
            char[] vocali = ['a', 'e', 'i', 'o', 'u'];

            foreach (char c in frase)
            {
                if (vocali.Contains(c))
                {
                    contatore++; 
                }
            }

            return contatore;
        }
    }
}
