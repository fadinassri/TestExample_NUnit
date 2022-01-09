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
            svcMoq = new MoqBookingService();
        }
        private IBookService svcMoq;

        [Test]
        public void checkOverlap_CallWithOverLap_ReturnOverlappedRecord()
        {
            //var svcMoq = new Mock<IBookService>();
            //svcMoq.Setup(x => x.GetAllBooking()).Returns(new System.Collections.Generic.List<BookIngDetail>());

            BookIngDetail b = new BookIngDetail();
            b.BookStatus = true;
            b.Destination = "Toronto";
            BookingHelper bkhg = new BookingHelper(svcMoq);
            var result = bkhg.checkOverlap(b);
            Assert.That(result.Contains("Toronto"));
        }




    }
}