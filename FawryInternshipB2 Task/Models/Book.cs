using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryInternshipB2_Task.Models
{
    public abstract class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        protected Book(string isbn, string title, int year, double price, string author)
        {
            ISBN = isbn;
            Title = title;
            Year = year;
            Price = price;
            Author = author;
        }

        public bool isOutdated(int maximumyear)
        {
            int currentYear = DateTime.Now.Year;
            return (currentYear - Year) > maximumyear;
        }
        public abstract double Buy(int quantity, string email, string address);

    }
}
