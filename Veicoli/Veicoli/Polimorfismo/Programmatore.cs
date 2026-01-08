using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Veicoli.Polimorfismo
{
    internal class Programmatore : Impiegato
    {
        public override double CalcolaStipendio(int giorniLavorati)
        {
            const double retribuzione = 90;
            double stipendio = retribuzione * giorniLavorati;
            stipendio += 100;
            return stipendio;
        }
    }
}
