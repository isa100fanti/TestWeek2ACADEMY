using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Academy.Esercitazione.Movements
{
    public abstract class Movement
    {
        public double Balance { get; set; } //saldo
        public DateTime LastOperation { get; set; }

        public abstract override string ToString();
    }
}
