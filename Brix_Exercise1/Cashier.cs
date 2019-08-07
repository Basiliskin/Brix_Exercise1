using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brix_Exercise1
{
    public class Cashier : Base
    {
        public override string ID() { return "Cashier:"+id; }
        public Cashier(int id) : base()
        {
            this.id = id.ToString();
        }
        public override int Process()
        {
            Order order = Orders.GetOne();
            if(order!=null)
            {
                return order.Process(this);
            }
            return 1; 
        }
    }
}
