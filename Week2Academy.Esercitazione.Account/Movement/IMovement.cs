using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Academy.Esercitazione.Account.Movement
{
    public interface IMovement
    {
        public double Balance { get; set; } //saldo
        public DateTime LastOperation { get; set; }
    }
}
