using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brix_Exercise1
{
    public class Client : Base
    {
        public override string ID() { return "Client:" + id; }
        public int Process(Order order, Cashier cashier)
        {
            Console.WriteLine(string.Format("{2}\t\t{0},{1}", ID(), order.ID(), cashier.ID()));
            return rand.Next(1, 5);
        }
    }
}
