using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmiConsole
{
    internal class ContaVocali
    {
        public int A { get; private set; }
        public int E { get; private set; }
        public int I { get; private set; }
        public int O { get; private set; }
        public int U { get; private set; }

        public string Frase { get; set; } = string.Empty;

        public ContaVocali()
        {
            Reset();
        }

        public void Reset()
        {
            A = 0;
            E = 0; 
            I = 0; 
            O = 0; 
            U = 0;
            Frase = string.Empty;
        }

        public void Incrementa(string frase)
        {
            Reset();
            Frase = frase;
            frase = frase.ToLower();

            foreach (char c in frase)
            {
                switch (c)
                {
                    case 'a': 
                        A++; 
                        break;
                    case 'e':
                        E++; 
                        break;
                    case 'i':
                        I++; 
                        break;
                    case 'o':
                        O++; 
                        break;
                    case 'u':
                        U++; 
                        break;
                    default:
                        continue;
                }
            }
        }

        public void Resoconto()
        {
            Console.WriteLine(
                $"""
                La frase "{Frase}" contiene le seguenti vocali:
                [
                    A: {A},
                    E: {E},
                    I: {I},
                    O: {O},
                    U: {U}
                ]
                """
            );
        }
    }
}
