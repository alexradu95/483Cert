using ConcurrentCollections;
using System;
using System.Collections.Concurrent;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConcurrentCollections.BlockingCollectionExample.BlockingCollectionRun();
            //ConcurrentBagDemo.ConcurrentBagExample();
            ConcurrentDictionaryDemo.ConcurrentDictionaryRun();
            Console.ReadKey();
        }
    }
}
