using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veicoli.Polimorfismo
{
    internal class UfficioPersonale
    {
        public void StampaBustaPaga(Impiegato impiegato, int giorniLavorati)
        {
            double stipendio = impiegato.CalcolaStipendio(giorniLavorati);
            string messaggio = $"{impiegato.nome} {impiegato.cognome}, stipendio: EUR {stipendio}";

            Console.WriteLine(messaggio);
        }
    }
}
