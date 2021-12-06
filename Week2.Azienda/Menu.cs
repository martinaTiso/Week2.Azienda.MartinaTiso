using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2.Azienda.Entities;

namespace Week2.Azienda
{
    internal class Menu

    {
        internal static void Start()
        {
            char choice;

            do
            {
                Console.WriteLine("Scegli un'opzione:" +
                    "\n[1]  Visualizzare tutti gli impiegati" +
                    "\n[2]  Mostrare tutti gli impiegati di un determinato settore" +
                    "\n[3]  inserire nuovo impiegato" +
                    "\n[4]  Eliminare Un Impegato" +
                    "\n[5]  Visulizzare gli impiegati con stipendio maggiore o minore " +
                    "\n[6]  Visualizzare gli impiegati con inserendo  una  skill" +
                    "\n[E] Esci");

                //recupero scelta utente -> choice
                choice = Console.ReadKey().KeyChar;

                //choice viene valutata nello switch
                switch (choice)
                {
                    case '1':
                        ViewAllImpiegati();
                        break;
                     
                    case '2':
                       
                        ;
                        break;
                    case '3':
                      ;
                        break;
                    case '4':
                        DeleteImpiegato();
                        break;
                    case '5':

                        break;
                    case 'E':
                        Console.WriteLine("Operazioni concluse. Arrivederci!");
                        break;
                    default:
                        Console.WriteLine("Scelta non valida");
                        break;
                }
            } while (choice != 'E');
        }




        private static void ViewAllImpiegati()
        {  // volevo  utilizzare il metodo usato dentro a Person per ricavarmi quelle informaioni ma ho cercato online  qualche aiuto ma non ho trovato nulla
            return;
        }



        // CANCELLARE UN IMPIEGATO
        private static void DeleteImpiegato()
        {
            //Utente inserisce il codice
            string codiceFiscale = GetInfo("codicefiscale dell'impiegato da eliminare");

            
            Impiegato impiegati = Test.GetByCode(codiceFiscale);

            if (impiegati != null)
            {
                //se c'è, lo posso cancellare
                bool isDeleted = Test.Delete(impiegati);

                if (isDeleted)
                {
                    Console.WriteLine("impiegato eliminato correttamente");
                }
                else
                {
                    Console.WriteLine("Rimozione non completata");
                }
            }
            else
            {
                //se non c'è
                Console.WriteLine("Non c'è nessun impiegato con questo codiceFiscale");
            }
        }
        private static string GetInfo(string message)
        {
            string info;
            do
            {
                Console.Write($"Inserisi il {message}: ");
                info = Console.ReadLine().ToUpper();
            } while (string.IsNullOrWhiteSpace(info));

            return info; //conterrà ciò che ha scritto l'utente
        }


    }
   

}



