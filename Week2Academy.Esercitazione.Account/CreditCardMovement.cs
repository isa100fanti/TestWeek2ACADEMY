using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Academy.Esercitazione.Library
{
    public enum CardType
    {
        Amex,
        Visa,
        Mastercard,
        Other
    }
    public class CreditCardMovement : IMovement
    {
        public int CardNumber { get; set; }
        public double Balance { get; set; }
        public DateTime LastOperation { get; set; }
        public CardType CardType { get; set; }

        public CreditCardMovement(double balance, DateTime lastop, int cardnum, int cardT)
        {
            Balance = balance;
            LastOperation = lastop;
            CardNumber = cardnum;
            if(cardT ==0)
            {
                CardType = CardType.Amex;
            }
            else if (cardT == 1)
            {
                CardType = CardType.Visa;
            }
            if (cardT == 2)
            {
                CardType = CardType.Mastercard;
            }
            if (cardT == 3)
            {
                CardType = CardType.Other;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"------- Balance {Balance}");
            sb.AppendLine($"Last Operation {LastOperation}");
            sb.AppendLine($"Credit card N {CardNumber} Card Type {CardType}");

            return sb.ToString();
        }
    }
}
