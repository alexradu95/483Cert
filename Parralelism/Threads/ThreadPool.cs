using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threads
{
    class ThreadPoolExample
    {
        static void DoWork(object state)
        {
            Console.WriteLine("Doing work: {0}", state);
            Thread.Sleep(500);
            Console.WriteLine("Work finished: {0}", state);
        }
        public static void ThreadPoolStuff()
        {
            for (int i = 0; i < 50; i++)
            {
                int stateNumber = i;
                ThreadPool.QueueUserWorkItem(state => DoWork(stateNumber));
            }
            Console.ReadKey();
        }
        }
}
