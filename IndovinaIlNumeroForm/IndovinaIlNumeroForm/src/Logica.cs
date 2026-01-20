using System;
using System.Collections.Generic;
using System.Text;

namespace IndovinaIlNumeroForm.src
{
    public class Logica
    {
        private readonly Random _r = new();
        public int Minimo { get; set; } = 1;
        public int Massimo { get; set; } = 101;
        public int NumeroDaIndovinare { get; private set; }
        public int Tentativi { get; private set; }

        public int MaxTentativi
        {
            get
            {
                return (int)Math.Floor(Math.Log2(Massimo)) + 1;
            }
        }

        public void Reset()
        {
            Tentativi = 0;
            NumeroDaIndovinare = _r.Next(Minimo, Massimo);
        }

        public int? ValidateInput(string userInput)
        {
            if (Int32.TryParse(userInput, out int result))
            {
                if (result >= Minimo &&  result < Massimo)
                {
                    return result; 
                }
            }
            
            return null;
        }

        public EnumEsito ControllaNumero(int inputUtente)
        {
            Tentativi++;

            if (inputUtente > NumeroDaIndovinare)
            {
                return EnumEsito.Minore;
            }

            if (inputUtente < NumeroDaIndovinare)
            {
                return EnumEsito.Maggiore;
            }

            return EnumEsito.Uguale;
        }

        public static string Esito(EnumEsito controllo)
        {           
            return controllo switch
            {
                EnumEsito.Uguale => "INDOVINATO",
                EnumEsito.Maggiore => "Troppo piccolo",
                EnumEsito.Minore => "Troppo grande",
                _ => throw new Exception("L'esito può essere solo Minore, Uguale o Maggiore"),
            };
        }

        public string CommentoVittoria()
        {
            string commento = Tentativi <= MaxTentativi ? "Eccezionale!" : "Puoi fare di meglio...";
            return $"Hai vinto in {Tentativi} tentativi. {commento}";
        }
    }
}
