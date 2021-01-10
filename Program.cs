using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            //to initialize a property you have to use the  new keyword
            //using List
            //List requires 1 type of argument.
            var grades = new List<double>() {12.7, 34.1, 32.3};
            grades.Add(43.1);
            var result = 0.0;
            foreach (var number in grades)
            {
                result += number;
            }
            result /= grades.Count;
            //we using N1 to get only the first digit after the decemal.
            Console.WriteLine($" The average grade of the students is {result:N1}");

        }
    }
}
