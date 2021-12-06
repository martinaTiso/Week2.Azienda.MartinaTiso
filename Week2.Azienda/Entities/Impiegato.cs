using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Azienda.Entities
{
    internal abstract class Impiegato : Persona
    {
        public List<Skill> Skill { get; set; }=new List<Skill>();
        public Settore settore { set; get; }


        public Impiegato(string nome, string cognome, string codiceFiscale,List<Skill> skills,Settore settore) : base(nome, cognome, codiceFiscale)

        {
            skills = skills;

            settore = settore;
        }


        public abstract double GetSalario();
       



        public enum Settore
        {
            manutenzione,
            amministrazione,
            sviluppo,

        }

        public override void Stampaimpiegati()
        {
            Console.WriteLine($"{nome}{Cognome}-{settore}-{GetSalario}-{settore}-{Skill}");
        }

    }
}
   

   



