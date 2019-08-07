using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brix_Exercise1
{
    public static class Orders
    {
        static Queue<Order> orders = new Queue<Order>(); 

        public static int Count()
        {
            int n = 0;
            lock (orders)
            {
                n = orders.Count;
            }
            return n;
        }
        public static void Add(Order order)
        {
            lock(orders)
            {
                orders.Enqueue(order);
            }
        }
        public static Order GetOne()
        {
            Order order = null;
            lock (orders)
            {
                if (orders.Count > 0)
                {
                    order = orders.Dequeue();
                }
            }
            return order;
        }
    }
}
