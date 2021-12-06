using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Azienda.Entities
{
    internal class Stagista : Impiegato
    {

        //Lo Stagista è un impiegato ma ha anche:
        //Durata dello stage (in mesi. Esempio: 3)
        //Calcolo stipendio: lo stipendio mensile dello stagista è 600 €.


        int DurataStage = 3;
        double StipendioMensile = 600;


        public override  double GetSalario()
        {

            return StipendioMensile;
        }


        public Stagista(string nome,string cognome,string codiceFiscale,Settore settore  ,List<Skill >skills,int durataStage, double stipendioMensile):base(nome, cognome,codiceFiscale, skills, settore)
        {
            DurataStage = durataStage;
            StipendioMensile = stipendioMensile;


        }
        public override void Stampaimpiegati()
        {
            Console.WriteLine($"{nome}{Cognome}-{settore}-{GetSalario}-{settore}-{Skill}");
        }
    }
    
}
        
           



