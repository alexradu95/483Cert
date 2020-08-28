using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parralelism
{
    /*
     * The Parallel.For method can be used to parallelize the execution of a for loop, which is governed by a control variable
     * 
    */
    class ParralelFor
    {
        public static void CallParralelFor()
        {
            var items = Enumerable.Range(0, 500).ToArray();
            Parallel.For(0, items.Count(), i =>
            {
                WorkOnItem(items[i]);
            });

            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();
        }

        private static void WorkOnItem(object item)
        {
            Console.WriteLine("Started working on: " + item);
            Thread.Sleep(100);
            Console.WriteLine("Finished working on: " + item);
        }
    }
}
