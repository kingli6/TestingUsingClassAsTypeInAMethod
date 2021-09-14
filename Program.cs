using System;

namespace TestingUsingClassAsType
{
    class Program
    {
        static void Main(string[] args)
        {
            var book1 = new Book("Joes book");
            book1.AddGrade(9.0);
            book1.AddGrade(8.5);
            book1.AddGrade(11.7);

            //Making an instance of class Statistics but instead of new
            //we are using the object book1 and calling a method.
            //
            //method Getstatistics only returns the average, but here we can
            //get the other results (High and Low)      WRONG
            //it returns all of them, based on .Low .High .Average
            Statistics result = book1.GetStatistics();
            Console.WriteLine(result.Average);
            Console.WriteLine(result.High);
            Console.WriteLine(result.Low);
            //Console.WriteLine(book1.);
        }
    }
}
