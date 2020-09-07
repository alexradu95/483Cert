using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threads
{
    class AbortAThread
    {

        // A Thread object exposes an Abort method, which can be called on the thread to abort it.
        // The thread is terminated instantly.
        // Abort method does not work in .netCore
        public static void AbortThread()
        {
            Thread tickThread = new Thread(() =>
            {
                while (true)
                {
                    Console.WriteLine("Tick");
                    Thread.Sleep(1000);
                }
            });
            tickThread.Start();
            Console.WriteLine("Press a key to stop the clock");
            Console.ReadKey();
            tickThread.Abort();
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }

        // When a thread is aborted it is instantly stopped.This might mean that it leaves the program
        // in an ambiguous state, with files open and resources assigned. A better way to abort a thread is
        // to use a shared flag variable. Listing 1-24 shows how to do this. The variable tickRunning
        // is used to control the loop in tickThread.When tickRunning is set to false the thread ends.
        public static void AbortThreadWithSharedFlagVariable()
        {
            
            bool tickRunning = true;


            Thread tickThread = new Thread(() =>
            {
                while (tickRunning)
                {
                    Console.WriteLine("Tick");
                    Thread.Sleep(1000);
                }
            });
            tickThread.Start();
            Console.WriteLine("Press a key to stop the clock");
            Console.ReadKey();
            tickRunning = false;
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();

        }
    }
}
