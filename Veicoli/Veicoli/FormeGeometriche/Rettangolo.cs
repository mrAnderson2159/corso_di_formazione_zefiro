using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veicoli.FormeGeometriche
{
    // Possiamo usare la sintassi del costruttore primario: mettiamo i parametri direttamente davanti alla classe
    // e nella dichiarazione degli attributi, indichiamo che questi prendono il valore dagli argomenti passati al
    // costruttore
    internal class Rettangolo(double Base, double Altezza) : ICalcoloGeometrico
    {   
        // Base dopo '=' è la base passata al costruttore
        public double Base { get; set; } = Base;
        public double Altezza { get; set; } = Altezza;

        public override string ToString()
        {
            return $"Rettangolo di base {Base} e altezza {Altezza}";
        }

        public override bool Equals(object? obj)
        {
            // Domando se obj è un'istanza di Rettangolo e ne salvo la conversione in una variabile
            // chiamata other. Se "obj is not Rettangolo" ritorna true, abbiamo finito, e other viene comunque
            // cancellata, altrimenti other diventa
            //
            //      Rettangolo other = other as Rettangolo;
            //
            // e possiamo usarlo per confrontare gli attributi
            if (obj is not Rettangolo other) return false;

            return Base == other.Base && Altezza == other.Altezza;
        }

        public double CalcolaArea()
        {
            return Base * Altezza;
        }

        public double CalcolaPerimetro()
        {
            return (Base + Altezza) * 2;
        }
    }
}
