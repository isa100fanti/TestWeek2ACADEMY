using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Academy.Esercitazione.Movements
{
    public class TransferMovement : Movement
    {
        public string OriginBank { get; set; }
        public string DestinationBank { get; set; }

        public TransferMovement(double balance, DateTime lastop, string originb,string destb)
        {
            Balance = balance;
            LastOperation = lastop;
            OriginBank = originb;
            DestinationBank = destb;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"------- Balance {Balance}");
            sb.AppendLine($"Last Operation {LastOperation}");
            sb.AppendLine($"From {OriginBank} To {DestinationBank}");

            return sb.ToString();
        }
    }
}
