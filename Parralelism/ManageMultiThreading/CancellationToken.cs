using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManageMultiThreading
{
    class CancellationTokenDemo
    {
        static CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        static void Clock()
        {
            while (!cancellationTokenSource.IsCancellationRequested)
            {
                Console.WriteLine("Tick");
                Thread.Sleep(500);
            }
        }

        static void SecondClock(CancellationToken cancellationToken)
        {
            int tickCount = 0;
            while (!cancellationToken.IsCancellationRequested && tickCount < 20)
            {
                tickCount++;
                Console.WriteLine("Tick");
                Thread.Sleep(100);
            }
            cancellationToken.ThrowIfCancellationRequested();
        }
        public static void RunCancellationTokenExample()
        {
            Task.Run(() => SecondClock(cancellationTokenSource.Token));
            Console.WriteLine("Press any key to stop the clock");
            Console.ReadKey();
            cancellationTokenSource.Cancel();
            Console.WriteLine("Clock stopped");
            Console.ReadKey();
        }
    }
}
