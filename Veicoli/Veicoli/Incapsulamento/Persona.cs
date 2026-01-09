using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veicoli.Incapsulamento
{
    internal class Persona
    {
        // Le variabili private iniziano per underscore
        private string _nome;
        private string _cognome;


        // Le property hanno la funzione di definire i metodi per leggere e scrivere
        // le variabili private. Devono iniziare per lettera maiuscola
        public string Nome 
        { 
            get 
            { 
                return _nome; 
            }
            set 
            { 
                if (value.Length < 2)
                {
                    throw new Exception("Nome troppo corto");
                }
                _nome = value;
            } 
        }
        
        // Se le operazioni sono banali come in questo caso,
        // si può sottointendere il body dei metodi
        public string Cognome { get; set; }
        public string CodiceFiscale { get; set; }
        public string Citta { get; set; }
        public bool Vivo { get; set; }


        public Persona()
        {
            Vivo = true;
        }

        public Persona(string Nome, string Cognome, string CodiceFiscale) : this()
        {
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.CodiceFiscale = CodiceFiscale;
        }

        public override string ToString()
        {
            return $"Nome: {this.Nome}\nCognome: {this.Cognome}\nCodice Fiscale: {this.CodiceFiscale}\nCittà: {this.Citta}\nIn vita: {this.Vivo}";
        }
    }
}
