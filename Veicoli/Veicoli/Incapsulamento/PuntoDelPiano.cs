using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veicoli.Incapsulamento
{
    internal class PuntoDelPiano
    {
        public double X {  get; set; }
        public double Y { get; set; }

        public PuntoDelPiano(double X, double Y) 
        { 
            this.X = X;
            this.Y = Y;
        }

        public override bool Equals(object? obj)
        {
            // object viene definito con ? che significa nullable

            // Se l'oggetto è nullo, di certo non sono uguali
            if (obj == null) return false;

            // Facciamo un type casting per verificare se l'oggetto è 
            // di tipo PuntoDelPiano, se non lo è il type casting
            // ritorna null e quindi i due oggetti sono diversi

            PuntoDelPiano other = obj as PuntoDelPiano;

            if (other == null) return false;

            // Infine confrontiamo le dimensioni

            if (other.X == X  && other.Y == Y) return true;

            // Altrimenti ritorniamo false
            return false;
        }
    }
}
