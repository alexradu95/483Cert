using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{
    class AnonymousMethods
    {

        public static void AnonymousMethodsExample()
        {
            Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(500);
                }
            });

            Console.WriteLine("Task running..");
            Console.ReadKey();
        }
    }
}
