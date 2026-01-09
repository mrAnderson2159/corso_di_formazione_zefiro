using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veicoli.FormeGeometriche
{
    internal class Quadrato
    {
        public double Lato { get; set; }

        public Quadrato(double lato) 
        {
            Lato = lato;
        }

        public override string ToString()
        {
            return $"Quadrato di lato {Lato}";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) 
                return false;

            Quadrato altro = obj as Quadrato;

            if (altro == null) 
                return false;

            return altro.Lato == Lato;
        }
    }
}
