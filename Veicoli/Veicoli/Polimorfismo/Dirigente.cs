using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veicoli.Polimorfismo
{
    internal class Dirigente : Impiegato
    {
        public override double CalcolaStipendio(int giorniLavorati)
        {
            return 150 * giorniLavorati;
        }
    }
}
