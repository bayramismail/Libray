using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppBlazor.Models
{
    public class BookListViewModel
    {
        public int Id { get; set; }
        public int WriterId { get; set; }
        public int PublisherId { get; set; }
        public int BookTypeId { get; set; }
        public int DonatorId { get; set; }
        public string BookName { get; set; }
        public string ISBNNumber { get; set; }
        public int YearOfPrinting { get; set; }
        public int NumberOfPages { get; set; }
        public string BookDescription { get; set; }
        public int CurrentNumber { get; set; }
    }
}
