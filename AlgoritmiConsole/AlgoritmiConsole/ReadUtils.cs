using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmiConsole
{
    internal class ReadUtils
    {
        public static int ReadIntWithConvert(string? prompt = null)
        {
            string? userInput;

            while (true)
            {
                if (prompt != null)
                {
                    Console.Write(prompt);
                }
                userInput = Console.ReadLine();

                try
                {
                    return Convert.ToInt32(userInput);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"'{userInput}' non è un numero valido\n");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"'{userInput}' è un numero troppo grande\n");
                }

            }
        }

        public static int ReadIntWithTryParse(string? prompt = null)
        {
            string? userInput;

            while (true)
            {
                if (prompt != null)
                {
                    Console.Write(prompt);
                }
                userInput = Console.ReadLine();

                // Utilizzo out per caricare il risultato della conversione del numero in una variabile che dichiaro 
                // in questo momento stesso. Equivalentemente avrei potuto fare
                //      int result;
                //
                //      Int32.TryParse(userInput, out result)
                if (Int32.TryParse(userInput, out int result))
                {
                    return result;
                }

                Console.WriteLine($"'{userInput}' non è un numero valido\n");
            }
        }
    }
}
