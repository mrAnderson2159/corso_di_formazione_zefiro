using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veicoli.Polimorfismo
{
    internal class Impiegato : Persona
    {
        //TODO i campi della classe si definiscono in maniera diversa
        public string matricola;
        public string reparto;

        public virtual double CalcolaStipendio(int giorniLavorati)
        {
            return 80 * giorniLavorati;
        }
    }
}
