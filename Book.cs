using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Book
    {
        //creating a cnstructor method
        public Book()
        {
            var grades = new List<double>();
        }
        public void AddGrade(double grade) {
               if(grade >= 0) {
                   grades.Add(grade);
                   Console.WriteLine($"the new grade is {grade}");
               }
        }
        List<double> grades = new List<double>();

    }
}