using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threads
{
    class CreateThread
    {
        static void ThreadHello()
        {
            Console.WriteLine("Hello from another thread");
            Thread.Sleep(2000);
        }

        public static void CreateThreadAndStart()
        {
            Thread thread = new Thread(ThreadHello);
            thread.Start();
        }

        public static void CreateThreadUsingThreadStart()
        {
            ThreadStart ts = new ThreadStart(ThreadHello);
            Thread thread = new Thread(ts);
            thread.Start();
        }

        public static void CreateThreadLambda()
        {
            Thread thread = new Thread(() =>
            {
                Console.WriteLine("Hello from the thread");
                Thread.Sleep(1000);
            });

            thread.Start();
            thread.Join();
            Console.WriteLine("Press a key to end.");
            Console.ReadKey();
        }
    }
}
