using System;
using System.Threading;
using System.Threading.Tasks;

namespace Parralelism
{
    /// <summary>
    /// The Parallel.Invoke method can start a large number of tasks at once. You have no
    /// control over the order in which the tasks are started or which processor they are assigned to.
    /// The Parallel.Invoke method returns when all of the tasks have completed. You can see
    /// the output from the program here.
    /// </summary>
    class ParralelInvoke
    {
        static void CallParallelInvoke()
        {
            Parallel.Invoke(() => Task1(), () => Task2());
            Console.ReadKey();
        }

        static void Task1()
        {
            global::System.Console.WriteLine("Task 1 starting");
            Thread.Sleep(6000);
            global::System.Console.WriteLine("Task 1 ending");
        }

        static void Task2()
        {
            global::System.Console.WriteLine("Task 2 starting");
            Thread.Sleep(6000);
            global::System.Console.WriteLine("Task 2 ending");
        }
    }
}
