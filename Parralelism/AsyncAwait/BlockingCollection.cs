using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentCollections
{
    // The program creates a thread
    // that attempts to add 10 items to a BlockingCollection, which has been created to hold
    // five items.After adding the 5th item this thread is blocked.The program also creates a thread
    // that takes items out of the collection.As soon as the read thread starts running, and takes some
    // items out of the collection, the writing thread can continue.
     
    class BlockingCollectionExample
    {

        public static void BlockingCollectionRun()
        {
            BlockingCollection<int> data = new BlockingCollection<int>(5);

            Task.Run(() =>
            {
                for (int i = 0; i < 11; i++)
                {
                    data.Add(i);
                    Console.WriteLine("Data {0} added succesfully", i);
                }
            });

            Console.ReadKey();
            Console.WriteLine("Reading collection");

            Task.Run(() =>
            {
                while (!data.IsCompleted)
                {
                    try
                    {
                        int v = data.Take();
                        Console.WriteLine("Data {0} taken sucessfully.", v);
                    }
                    catch (InvalidOperationException) { }
                }
            });

            Console.ReadKey();
        }
    }
}
