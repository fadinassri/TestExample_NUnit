using Models;
using System;

namespace TestExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BookIngDetail b = new BookIngDetail();
            b.BookStatus = true;
           var result =  BookingHelper.checkOverlap(b);
            Console.WriteLine(result);
        }
    }
}
