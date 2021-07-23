using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2Academy.Esercitazione.Movements;

namespace Week2Academy.Esercitazione
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public string BankName { get; set; }
        public double Credit { get; set; }
        public DateTime LastMovement { get; set; }

        public List<Movement> movements { get; set; } = new List<Movement>();

        //operator + o - sulla lista dei movimenti
        //saldo e data ultima operaz
        //mov + e - da aggiungere alla lista

        public static List<Movement> operator +(Account a, Movement m )
        {
            List<Movement> list = new List<Movement>();
            a.Credit += m.Balance; //sommo al credito tot il saldo del movimento
            a.LastMovement = m.LastOperation;
            list.Add(m);
            return list;

        }
        public static List<Movement> operator -(Account a, Movement m)
        {
            List<Movement> list = new List<Movement>();
            a.Credit -= m.Balance; //sottraggo al credito tot il saldo del movimento
            a.LastMovement = m.LastOperation;
            list.Add(m);
            return list;

        }

        public string Statement()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"N {AccountNumber} Bank: {BankName} Credit {Credit}");
            sb.AppendLine($"Last Movement {LastMovement}");
            sb.AppendLine($"Movements: {movements}"); //lista
            return sb.ToString();
        }


    }
}
