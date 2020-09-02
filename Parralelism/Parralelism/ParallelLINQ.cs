using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parralelism
{
    /*
     * 
        The AsParallel method examines the query to determine if using a parallel version
        would speed it up. If it is decided that executing elements of the query in parallel would
        improve performance, the query is broken down into a number of processes and each is run
        concurrently. If the AsParallel method can’t decide whether parallelization would improve
        performance the query is not executed in parallel. If you really want to use AsParallel you
        should design the behavior with this in mind, otherwise performance may not be improved and
        it is possible that you might get the wrong outputs.
     * 
     */
    class ParallelLINQ
    {
        class Person
        {
            public string Name { get; set; }
            public string City { get; set; }
        }
        public static void CallParallelLINQ()
        {
            Person[] people = new Person[] {
                new Person { Name = "Alan", City = "Hull" },
                new Person { Name = "Beryl", City = "Seattle" },
                new Person { Name = "Charles", City = "London" },
                new Person { Name = "David", City = "Seattle" },
                new Person { Name = "Eddy", City = "Paris" },
                new Person { Name = "Fred", City = "Berlin" },
                new Person { Name = "Gordon", City = "Hull" },
                new Person { Name = "Henry", City = "Seattle" },
                new Person { Name = "Isaac", City = "Seattle" },
                new Person { Name = "James", City = "London" }
            };

            var result = from person in people.AsParallel()
                         //.WithDegreeOfParallelism(4)
                         //.WithExecutionMode(ParallelExecutionMode.ForceParallelism)
                         where person.City == "Seattle"
                         select person;
            //foreach (var person in result)
            //    Console.WriteLine(person.Name);

            result.ForAll(person => Console.WriteLine(person.Name));
            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();
        }
    }
}
