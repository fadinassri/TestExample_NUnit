using Models;
using System;

namespace TestExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string Dest = "";
            while (Dest != "exit")
            {
                Console.WriteLine("Hello World!");
                Dest = Console.ReadLine();

                BookIngDetail b = new BookIngDetail();
                b.BookStatus = true;
                b.Destination = Dest;
                BookingHelper bkhg = new BookingHelper(new BookService());
                var result = bkhg.checkOverlap(b);
                Console.WriteLine(result);
                Console.WriteLine("***********************************************************************************************************************");

            }
        }
    }
}
