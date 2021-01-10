using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Book
    {
        public void AddGrade(double grade) {
               if(grade >= 0) {
                   grades.Add(grade);
                   Console.WriteLine($"the new grade is {grade}");
               }
        }
        List<double> grades;
    }
}