using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threads
{
    class PassingDataToAThread
    {
        static void WorkOnData(object data)
        {
            Console.WriteLine("Working on: {0}", data);
            Thread.Sleep(1000);
        }

        // A program can pass data into a thread when it is created by using the
        // ParameterizedThreadStart delegate. This specifies the thread method as one that
        // accepts a single object parameter. The object to be passed into the thread is then placed in the Start method
        static void PassParamsToThread()
        {
            ParameterizedThreadStart ps = new ParameterizedThreadStart(WorkOnData);
            Thread thread = new Thread(ps);
            thread.Start(99);
        }
    }
}
