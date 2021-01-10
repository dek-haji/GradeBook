using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            //to initialize a property you have to use the  new keyword
            var numbers = new[] {12.7, 34.2, 32.3};
            //using List
           // List grades;

            var result = 0.0;
            foreach (var number in numbers)
            {
                result += number;
            }

            Console.WriteLine(result);


        }
    }
}
