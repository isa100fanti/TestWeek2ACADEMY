using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Academy.Esercitazione.Movements
{
    public class CashMovement : Movement
    {
        public String Esecutore { get; set; } //rivenditore
        public CashMovement(double balance, DateTime lastop, string esecutore)
        {
            Balance = balance;
            LastOperation = lastop;
            Esecutore = esecutore;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"------- Balance {Balance}");
            sb.AppendLine($"Last Operation {LastOperation}");
            sb.AppendLine($"Esecutore {Esecutore}");

            return sb.ToString();
        }
    }
}
