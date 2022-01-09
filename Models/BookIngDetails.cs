using System;

namespace Models
{
    public class BookIngDetail
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Destination { get; set; }
        public bool BookStatus { get; set; }

    }
}
