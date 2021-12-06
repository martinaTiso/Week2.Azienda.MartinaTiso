using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Azienda.Entities
{
    internal class Manager :Impiegato
    {

        int OreStraordinario { get; set; }
        double StipendioBase { get; set; }

        public Manager(string nome, string cognome, string codiceFiscale, Settore settore, List<Skill> skills, int oreStraordinario, double stipendiobase) : base(nome, cognome, codiceFiscale, skills, settore)
        {
            OreStraordinario = oreStraordinario;
            StipendioBase = stipendiobase;


        }

        public override  double GetSalario()
        {
            return  StipendioBase + (OreStraordinario * 10);
        }

        public override void Stampaimpiegati()
        {
            Console.WriteLine($"{nome}{Cognome}-{settore}-{GetSalario}-{settore}-{Skill}");
        }
    }

}

