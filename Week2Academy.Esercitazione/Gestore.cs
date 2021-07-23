using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2Academy.Esercitazione.Library;

namespace Week2Academy.Esercitazione
{
    

    public class Gestore
    {
        

        internal static void AnalizzaScelta(int scelta)
        {
            
            switch(scelta)
            {
                case 1: //apri account
                    ApriAccount();
                    break;
                case 2: //aggiungi moviementi
                    AggiungiMovimento();
                    break;
                case 3://stampa statement
                    StampaEstratto();
                    break;
                case 4:
                    Console.WriteLine("arrivederci!");
                    
                    break;
                default:
                    Console.WriteLine("scegli una delle opzioni!");
                    break;
            }
        }


        private static void ApriAccount()
        {
            Console.WriteLine("inserisci il numero");
            int bankN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inserisci il noem della banca");
            string bankName = Console.ReadLine();
            Console.WriteLine("inserisci il saldo");
            double credit = Convert.ToDouble(Console.ReadLine());
            Account account = new Account(bankN, bankName, credit);
            Console.WriteLine("account creato!");



        }

        
        private static void AggiungiMovimento()
        {
            
            bool ok = true;
            do
            {
                Console.WriteLine("che movimento vuoi aggiungere?");
                Console.WriteLine("1. cash");
                Console.WriteLine("2. credit card");
                Console.WriteLine("3. transfert");
                int scelta = Convert.ToInt32(Console.ReadLine());
                switch (scelta)
                {
                    case 1: //cash
                        Console.WriteLine("inserisci il saldo dell'operazione");
                        double saldo = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("inserisci la data dell'operazione");
                        bool success = DateTime.TryParse(Console.ReadLine(), out DateTime dataOp);
                        if (!success)
                        {
                            Console.WriteLine("inserisci una data valida!");
                            success = DateTime.TryParse(Console.ReadLine(), out dataOp);

                        }

                        Console.WriteLine("inserisci l'esercente");
                        string esecutore = Console.ReadLine();

                        IMovement mCash = new CashMovement(saldo, dataOp, esecutore);

                        
                        break;
                    case 2: //credit
                        Console.WriteLine("inserisci il saldo dell'operazione");
                        saldo = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("inserisci la data dell'operazione");
                        success = DateTime.TryParse(Console.ReadLine(), out dataOp);
                        if (!success)
                        {
                            Console.WriteLine("inserisci una data valida!");
                            success = DateTime.TryParse(Console.ReadLine(), out dataOp);

                        }

                        Console.WriteLine("inserisci il numero di carta");
                        int cardN = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("inserisci il tipo di carta: 1 amex,2 visa,3 mastercard, 4 other");
                        int tipoC = Convert.ToInt32(Console.ReadLine());
                        

                        IMovement mCredit = new CreditCardMovement(saldo, dataOp, cardN, tipoC);
                       
                        break;
                    case 3: //transfert
                        Console.WriteLine("inserisci il saldo dell'operazione");
                        saldo = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("inserisci la data dell'operazione");
                        success = DateTime.TryParse(Console.ReadLine(), out dataOp);
                        if (!success)
                        {
                            Console.WriteLine("inserisci una data valida!");
                            success = DateTime.TryParse(Console.ReadLine(), out dataOp);

                        }

                        Console.WriteLine("inserisci la banca di origine");
                        string bankO = Console.ReadLine();
                        Console.WriteLine("inserisci la banca di destinazione");
                        string bankD = Console.ReadLine();

                        IMovement mTrans = new TransfertMovement(saldo, dataOp, bankO, bankD);
                        break;
                }
                Console.WriteLine("vuoi fare altre operazioni? s/n");
                string risp = Console.ReadLine();
                if (risp == "n")
                {
                    ok = false;
                }

            } while (ok);  //finchè è true
        }


        private static void StampaEstratto()
        {
            Account a2 = new Account();
                a2.Statement();
        }

    }
}
