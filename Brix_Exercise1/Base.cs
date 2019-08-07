using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brix_Exercise1
{
    public abstract class Base
    {
        public static Random rand = new Random();
        protected string id = rand.Next().ToString();
        public virtual string ID() { return id;  }
        public virtual int Process() {
            Console.WriteLine(string.Format("Processing:{0}", ID())); 
            return 0;
        }
    }
}
