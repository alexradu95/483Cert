using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{

    class LambdaBuiltInTypes
    {
        /*
           The Func types provide a range of delegates for methods that accept values and return
           results. Listing 1-74 shows how the Func type is used to create an add behavior that has the
           same return type and parameters as the IntOperation delegate in Listing 1-71. There are
           versions of the Func type that accept up to 16 input items. The add method here accepts two
           integers and returns an integer as the result.
        */
        Func<int, int, int> add = (a, b) => a + b;
        /*
            If the lambda expression doesn’t return a result, you can use the Action type that you saw
            earlier when we created our first delegates. The statement below creates a delegate called
            logMessage that refers to a lambda expression that accepts a string and then prints it to the
            console. For different forms of loging the logMessage delegate can be attached to other
            methods that save the log data to a file.
        */
        static Action<string> logMessage = (message) => Console.WriteLine(message);
        /*  
            The Predicate built in delegate type lets you create code that takes a value of a particular
            type and returns true or false. The dividesByThree predicate below returns true if the
            value is divisible by 3.
        */
        Predicate<int> dividesByThree = (i) => i % 3 == 0;
    }
}
