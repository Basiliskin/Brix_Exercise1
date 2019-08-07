using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brix_Exercise1
{
    public class SuperMarket : Base
    {
        public override string ID() { return "SuperMarket:" + Orders.Count(); } 
        public override int Process()
        {
            Orders.Add(new Order());
            base.Process();
            return 1;
        }
    }
}
