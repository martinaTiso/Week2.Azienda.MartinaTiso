using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2.Azienda.Entities;
using static Week2.Azienda.Entities.Impiegato;

namespace Week2.Azienda
{
    internal class Test
    {
        //LISTA DI SKILLS
        private static List<Skill> skills = new List<Skill>()
        {

            new Skill() { Codice = "C01", Descrizione= "Problem Solving", },
            new Skill() { Codice = "C02",  Descrizione = "Gestione Dello Stress", },
            new Skill() { Codice = "C03",  Descrizione = "Team Management", },
            new Skill() { Codice = "C04",  Descrizione = "Capacità decisionale", }
        };


        //LISTA IMPIEGATI
        public static List<Impiegato> impiegati = new List<Impiegato>()
       {

            new Manager("Marco","Rossi","SMTINTE63D985S",Impiegato.Settore.manutenzione, skills = new List<Skill>(){ },32,45),
            new Manager("Luca","Rosi","SMTINTr63D985S",Impiegato.Settore.amministrazione,skills = new List<Skill>(){ },34,45),
              new Tecnico("Roberto","Rossi","RMTINTE63D985r",Impiegato.Settore.manutenzione,skills = new List<Skill>(){},32,20),
               new Tecnico("Luigic","Rosso","RMTINTE63D985r",Impiegato.Settore.manutenzione,skills = new List<Skill>(){},37,21),
                new Stagista("Marco","Rossi","SMTINTE63D985S",Impiegato.Settore.amministrazione,skills = new List<Skill>(){},32,45),
                 new Stagista("Marco","Bianchi","SMTINTE63D985S",Impiegato.Settore.manutenzione,skills = new List<Skill>(){},30,45)

        };

              
        internal static Impiegato GetByCode(string codiceFiscale)
        {
            foreach (Impiegato i in impiegati)
            {
                if (i.CodiceFiscale == codiceFiscale)
                {
                    return i;
                }
            }

            return null;

        }


        internal static bool Delete(Impiegato i)
        {
            if (i != null) //controllo dell'input al metodo
            {
                return impiegati.Remove(i);
            }

            return false;
        }
    }
    
}

    


 



