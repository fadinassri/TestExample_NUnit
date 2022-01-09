using Models;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace TestExample
{
    public class BookingHelper
    {
        IBookService svc = null;
        public BookingHelper(IBookService svc)
        {
            this.svc = svc;
        }

        public string checkOverlap(BookIngDetail book)
        {
            if (book.BookStatus == false)
                return "";


            var allBooking = svc.GetAllBooking();
            var found = allBooking.FirstOrDefault(x => x.Destination == book.Destination);
            if (found != null)
                return JsonConvert.SerializeObject(found);



            return JsonConvert.SerializeObject(allBooking);

        }


    }
}
