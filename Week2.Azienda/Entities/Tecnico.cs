using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Azienda.Entities
{
    internal class Tecnico : Impiegato
    {
        double PagaOraria { get; set; }
        int OreLavorate { get; set; }

        public override double GetSalario()
        {

            return (double)OreLavorate * PagaOraria;
        }

        public Tecnico(string nome, string cognome, string codiceFiscale, Settore settore, List<Skill> skills, double pagaOraria, int orelavorate) : base (nome, cognome, codiceFiscale, skills, settore)
        {

            PagaOraria = pagaOraria;
            OreLavorate = orelavorate;
        }
        public override void Stampaimpiegati()
        {
            Console.WriteLine($"{nome}{Cognome}-{settore}-{GetSalario}-{settore}-{Skill}");
        }
    }
}


