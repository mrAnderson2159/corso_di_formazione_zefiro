using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veicoli.AstrazioneVeicoli
{
    internal class Automobile : VeicoloTerrestre
    {
        public int numeroPorte;
        public int tipoAlimentazione;
        public string targa;

        public Automobile()
        {
            this.numeroRuote = 4;
        } 

        public override void Avanza()
        {
            Console.WriteLine("L'automobile si muove");
        }

        public virtual int velocitaMassima() { return 130; }
    }
}
