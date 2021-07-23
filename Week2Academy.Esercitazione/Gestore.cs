using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Academy.Esercitazione
{
    public class Gestore
    {
        internal static void Menu()
        {
            Console.WriteLine("cosa vuoi fare?");
            Console.WriteLine("1.Apri un account");
            Console.WriteLine("2. inserisci movimenti");
            Console.WriteLine("3. stampa estratto conto");
            int scelta = Convert.ToInt32(Console.ReadLine());
            AnalizzaScelta(scelta);

        }

        private static void AnalizzaScelta(int scelta)
        {
            switch(scelta)
            {
                case 1: //apri account
                    break;
                case 2: //aggiungi moviementi
                    break;
                case 3:
                    break;
            }
        }
    }
}
