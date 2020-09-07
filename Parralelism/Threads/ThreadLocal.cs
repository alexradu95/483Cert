using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threads
{
    class ThreadLocal
    {
        // If your program needs to initialize the local data for each thread you can use the
        // ThreadLocal<t> class. When an instance of ThreadLocal is created it is given a
        // delegate to the code that will initialize attributes of threads.
        public static ThreadLocal<Random> RandomGenerator =
            new ThreadLocal<Random>(() =>
            {
                return new Random(2);
            });

        public static void RunThreadLocalExample()
        {
            Thread t1 = new Thread(() =>
            {
                for (int i=0; i<5; i++)
                {
                    Console.WriteLine("t1: {0}", RandomGenerator.Value.Next(10));
                    Thread.Sleep(500);
                }
            });

            Thread t2 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("t2: {0}", RandomGenerator.Value.Next(10));
                    Thread.Sleep(500);
                }
            });

            t1.Start();
            t2.Start();
            Console.ReadKey();
        }


    }
}
