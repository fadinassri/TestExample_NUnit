using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookingController : Controller
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public BookingController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<BookIngDetail> Get()
        {

            List<BookIngDetail> books = new List<BookIngDetail>();

            for (int i = 0; i < 100; i=i + 15)
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
