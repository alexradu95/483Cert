using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threads
{
    class ThreadSyncronizationJoin
    {

        public static void ThreadSyncJoin()
        {
            Thread threadToWaitFor = new Thread(() =>
            {
                Console.WriteLine("Thread starting");
                Thread.Sleep(2000);
                Console.WriteLine("Thread done");
            });
            threadToWaitFor.Start();
            Console.WriteLine("Joining thread");
            threadToWaitFor.Join();
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }


    }
}
