using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace ConcurrentCollections
{
    class ConcurrentBagDemo
    {
        public static void ConcurrentBagExample()
        {
            ConcurrentBag<string> bag = new ConcurrentBag<string>();
            bag.Add("Rob");
            bag.Add("Miles");
            bag.Add("Hull");
            string str;
            if (bag.TryPeek(out str))
                Console.WriteLine("Peek: {0}", str);
            if (bag.TryTake(out str))
                Console.WriteLine("Take: {0}", str);
        }
    }
}
