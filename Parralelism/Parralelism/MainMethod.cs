using System;
using System.Collections.Generic;
using System.Text;

namespace Parralelism
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            //ParralelInvoke.CallParallelInvoke();
            //ParralelForEach.CallParralelForEach();
            //ParralelFor.CallParralelFor();
            //ParallelManagingLoop.ManageParallelFor();
            ParallelLINQ.CallParallelLINQ();
        }
    }
}
