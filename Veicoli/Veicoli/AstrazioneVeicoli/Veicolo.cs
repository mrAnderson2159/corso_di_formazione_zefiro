using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veicoli.AstrazioneVeicoli
{
    internal abstract class Veicolo
    {
        public string nome;
        public string marca;
        public double peso;

        public abstract void Avanza();
    }
}
