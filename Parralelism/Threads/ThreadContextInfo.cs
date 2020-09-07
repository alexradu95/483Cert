using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threads
{
    class ThreadContextInfo
    {
        static void DisplayThread(Thread t)
        {
            Console.WriteLine("Name: {0}", t.Name);
            Console.WriteLine("Culture: {0}", t.CurrentCulture);
            Console.WriteLine("Priority: {0}", t.Priority);
            Console.WriteLine("Context: {0}", t.ExecutionContext);
            Console.WriteLine("IsBackground?: {0}", t.IsBackground);
            Console.WriteLine("IsPool?: {0}", t.IsThreadPoolThread);
        }
        public static void DisplayThreadContext()
        {
            Thread.CurrentThread.Name = "Main method";
            DisplayThread(Thread.CurrentThread);
            Console.ReadKey();
        }
    }
}
