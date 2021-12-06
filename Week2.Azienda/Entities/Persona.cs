using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Azienda.Entities
{
    internal class Persona
    {


        public string nome { get; set; }
        public string Cognome { get; set; }
        public string CodiceFiscale { get; set; }


        public Persona(string nome, string cognome, string codiceFiscale)
        {
            Cognome = cognome; ;
            this.nome = nome;
            CodiceFiscale = codiceFiscale;
        }

        public virtual void Stampaimpiegati()
        {
            Console.WriteLine($"{nome}{Cognome}{CodiceFiscale}");
        }
    }
   

}

    

