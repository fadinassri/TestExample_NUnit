using Models;
using NUnit.Framework;
using TestExample;
using System.Linq;
using Moq;

namespace TestTestExample
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            _svcMoq = new Mock<IBookService>();
            System.Collections.Generic.List<BookIngDetail> value = new System.Collections.Generic.List<BookIngDetail>() {
            new BookIngDetail(){Id = 1, BookStatus=true, Destination="Toronto"},
            new BookIngDetail(){Id = 2, BookStatus=true, Destination="Jamaika"},
            new BookIngDetail(){Id = 3, BookStatus=true, Destination="BC"},
            };
            _svcMoq.Setup(x => x.GetAllBooking()).Returns(value);

        }
        private Mock<IBookService> _svcMoq;

        [Test]
        public void checkOverlap_CallWithOverLap_ReturnOverlappedRecord()
        {


            BookIngDetail b = new BookIngDetail();
            b.BookStatus = true;
            b.Destination = "Toronto";
            BookingHelper bkhg = new BookingHelper(_svcMoq.Object);
            var result = bkhg.checkOverlap(b);
            Assert.That(result.Contains("Toronto"));
        }




    }
}