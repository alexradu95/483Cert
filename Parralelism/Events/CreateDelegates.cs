using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    class CreateDelegates
    {
        delegate int IntOperation(int a, int b);
        static int Add(int a, int b)
        {
            Console.WriteLine("Add called");
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            Console.WriteLine("Subtract called");
            return a - b;
        }
        public static void CreateDelegatesExample()
        {
            // Explicitly create the delegate
            var op = new IntOperation((a,b) => {

                Console.WriteLine("Add called");
                return a + b;
            });

            Console.WriteLine(op(2, 2));
            // Delegate is created automatically
            // from method

            op = (a,b) => a-b;
            Console.WriteLine(op(2, 2));
            Console.ReadKey();
        }
    }
}
