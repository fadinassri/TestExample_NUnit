using Models;
using System.Collections.Generic;

namespace TestExample
{
    public interface IBookService
    {
        List<BookIngDetail> GetAllBooking();
    }
}