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
            
            Console.WriteLine("benvenuto sul sito della banca!");
            while (go)
            {
                Gestore.Menu();
            }
            Console.WriteLine("Arrivederci!");
        }
    }
}
