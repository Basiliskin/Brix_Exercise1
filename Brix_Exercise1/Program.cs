using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Brix_Exercise1
{
    class Program
    {
        static bool isActive = true;
        private static void TaskRun(Base current)
        {
            if(current is Cashier) Thread.Sleep(10000);
            while (isActive)
            {
                int sleep = current.Process();
                Thread.Sleep(sleep * 1000);
            } 
        }
        async static void RunAsyn()
        {
            var loadDataTasks = new Task[]
            {
                Task.Run( () =>  TaskRun(new SuperMarket())),
                Task.Run( () =>  TaskRun(new Cashier(1))),
                Task.Run( () =>  TaskRun(new Cashier(2))),
                Task.Run( () =>  TaskRun(new Cashier(3))),
                Task.Run( () =>  TaskRun(new Cashier(4))),
                Task.Run( () =>  TaskRun(new Cashier(5)))
            };

            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Press any key to stop");
            await Task.WhenAll(loadDataTasks);
        }
        static void Main(string[] args)
        {
            RunAsyn();
            Console.ReadKey();
            isActive = false;
            Console.WriteLine("done");
        }
    }
}
