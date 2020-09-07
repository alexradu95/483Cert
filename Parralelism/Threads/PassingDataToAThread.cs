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
        public static void PassParamsToThread(int x)
        {
            ParameterizedThreadStart ps = new ParameterizedThreadStart(WorkOnData);
            Thread thread = new Thread(ps);
            thread.Start(x);
        }

        // Another way to pass data into a thread is to specify the behavior of the thread as a lambda
        // expression that accepts a parameter.The parameter to the lambda expression is the data to be
        // passed into the thread.Listing 1-22 shows how this is done; the parameter is given the name
        // data in the lamba expression and the value 99 is passed into the lambda expression via the Start method.

        public static void PassParamsToLambdaThread(int x)
        {
            Thread thread = new Thread((data) =>
            {
                WorkOnData(data);
            });

            thread.Start(x);
        }
    }
}
