using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brix_Exercise1
{
    public class Order : Base
    {
        public override string ID() { return "Order:" + id; }
        Client client = new Client();
        public int Process(Cashier cashier)
        {
            return client.Process(this, cashier);
        } 
    }
}
