using Models;
using System;
using System.Collections.Generic;
using System.Text;
using TestExample;

namespace TestTestExample
{
    public class MoqBookingService : IBookService
    {
        public List<BookIngDetail> GetAllBooking()
        {
            List<BookIngDetail> books = new List<BookIngDetail>();

            for (int i = 0; i < 100; i = i + 15)
            {
                BookIngDetail b = new BookIngDetail();
                b.StartDate = DateTime.Today.AddDays(i);
                b.EndDate = DateTime.Today.AddDays(i + 14);
                b.Id = i;
                b.Destination = "Toronto";
                b.BookStatus = true;
                books.Add(b);
            }

            return books;
        }
    }
}
