using System;
using System.Collections.Generic;
using System.Text;

namespace IndovinaIlNumeroConsole
{
    internal class Logica
    {
        private readonly int _numero = new Random().Next(1, 101);
        public int Tentativi { get; private set; } = 0;

        public EnumEsito ControllaNumero(int inputUtente)
        {
            Tentativi++;

            if (inputUtente > _numero)
            {
                return EnumEsito.Minore;
            }
            
            if (inputUtente < _numero)
            {
                return EnumEsito.Maggiore;
            }
            
            return EnumEsito.Uguale;
        }

        public string Esito(EnumEsito controllo)
        {
            string commento = Tentativi <= 7 ? "Eccezionale!" : "Puoi fare di meglio...";

            return controllo switch
            {
                EnumEsito.Uguale => $"Hai vinto in {Tentativi} tentativi. {commento}",
                EnumEsito.Maggiore => "Il numero da indovinare è più grande",
                EnumEsito.Minore => "Il numero da indovinare è più piccolo",
                _ => throw new Exception("L'esito può essere solo Minore, Uguale o Maggiore"),
            };
        }
    }
}
