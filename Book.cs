using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingUsingClassAsType
{
    class Book
    {
        public string name;
        public List<double> grade;

        public Book(string name)
        {
            this.name = name;
            grade = new List<double>();
        }

        public void AddGrade(double grades)
        {
            grade.Add(grades);
        }

        //method that bridges a class as a type
        public Statistics GetStatistics()
        {
            Statistics result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (var number in grade)
            {
                result.Low = Math.Min(number, result.Low);
                result.High = Math.Max(number, result.High);
                result.Average += number;
            }
            result.Average /= grade.Count;
            return result;
        }
        


    }
}
