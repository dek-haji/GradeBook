using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book2 = new Book("Dek Haji's book");
            var name = new Names();
            var book = new Book("Nasri's book");
            book2.AddGrade(32.4);
            book.AddGrade(33.2);
            name.AddName("Sahra");

            book.ShowStatistics(book2);
            //to initialize a property you have to use the  new keyword
        //using List
        //List requires 1 type of argument.
        
    }
}
}
