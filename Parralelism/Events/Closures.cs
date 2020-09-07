using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{

    /// <summary>
    /// The method SetLocal declares a local variable called
    /// localInt and sets its value to 99. Under normal circumstances the variable localInt
    /// would be destroyed upon completion of the SetLocal method.However, the localInt
    /// variable is used in a lambda expression, which is assigned to the delegate getLocal.The
    /// compiler makes sure that the localInt variable is available for use in the lambda expression
    /// when it is subsequently called from the Main method. This extension of variable life is called a
    /// closure.
    /// </summary>
    class Closures
    {
        delegate int GetValue();
        static GetValue getLocalInt;

        static void SetLocalInt()
        {
            // Local variable set to 99
            int localInt = 99;
            // Set delegate getLocalInt to a lambda expression that
            // returns the value of localInt
            getLocalInt = () => localInt;
        }

        public static void ClosuresExample()
        {
            SetLocalInt();
            Console.WriteLine("Value of localInt {0}", getLocalInt());
            Console.ReadKey();
        }
    }
}
