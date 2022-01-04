using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Book
    {
          List<double> grades = new List<double>();
        private string name;
        //creating a cnstructor method
        public Book(string name)
        {
            var grades = new List<double>();
            this.name = name;
        }
        public void ShowStatistics(Book book)
        {
            var grades = new List<double>() { 12.7, 34.1, 32.3 };
        grades.Add(43.1);
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach (var number in grades)
            {
               highGrade = Math.Max(number, highGrade);
               lowGrade = Math.Min(number, lowGrade);
                result += number;
            }
    result /= grades.Count;
            //we using N1 to get only the first digit after the decemal.
            Console.WriteLine($" The average grade of the students is {result:N1}");
            Console.WriteLine($"The lowest number is {lowGrade}");
            Console.WriteLine($"The Highest number is {highGrade}");
        }
        public void AddGrade(double grade) {
               if(grade >= 0) {
                   grades.Add(grade);
                   Console.WriteLine($"the new grade is :{grade}");
               }
        }
    }
}