using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veicoli.FormeGeometriche
{
    internal interface ICalcoloGeometrico
    {
        double CalcolaArea();

        double CalcolaPerimetro();
    }
}
