using System;

namespace Week2Academy.Esercitazione
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Di creare un nuovo Account
            Di inserire diversi tipi di Movimenti (input dall'utente)
            Stampare i dati del conto e i movimenti
            */

            bool go = true;
            int scelta = 0;
            Console.WriteLine("benvenuto sul sito della banca!");
            while (scelta != 4)
            {
                Console.WriteLine("cosa vuoi fare?");
                Console.WriteLine("1.Apri un account");
                Console.WriteLine("2. inserisci movimenti");
                Console.WriteLine("3. stampa estratto conto");
                Console.WriteLine("4. esci");
                scelta = Convert.ToInt32(Console.ReadLine());
                Gestore.AnalizzaScelta(scelta);
                
            }
            Console.WriteLine("Arrivederci!");
        }
    }
}
