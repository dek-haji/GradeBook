using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            //to initialize a property you have to use the  new keyword
            var numbers = new[] {12.7, 34.1, 32.3};
            //using List
            //List requires 1 type of argument.
            var grades = new List<double>();
            grades.Add(12.7);
            grades.Add(13.7);
            grades.Add(32.7);
            grades.Add(43.1);
            var result = 0.0;
            foreach (var number in grades)
            {
                result += number;
            }

            Console.WriteLine(result);


        }
    }
}
