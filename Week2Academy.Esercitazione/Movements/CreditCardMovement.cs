using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Academy.Esercitazione.Movements
{
    public enum CardType
    {
        Amex,
        Visa,
        Mastercard,
        Other
    }
    public class CreditCardMovement : Movement
    {
        public int CardNumber { get; set; }

        public CreditCardMovement(double balance, DateTime lastop, int cardnum)
        {
            Balance = balance;
            LastOperation = lastop;
            CardNumber = cardnum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"------- Balance {Balance}");
            sb.AppendLine($"Last Operation {LastOperation}");
            sb.AppendLine($"Credit card N {CardNumber}");

            return sb.ToString();
        }
    }
}
