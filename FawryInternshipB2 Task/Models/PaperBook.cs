using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryInternshipB2_Task.Models
{
    public class PaperBook : Book
    {
        public int Stock { get; private set; }

        public PaperBook(string isbn, string title, int year, double price, string author, int stock)
            : base(isbn, title, year, price, author)
        {
            Stock = stock;
        }

        public override double Buy(int quantity, string email, string address)
        {
            if (Stock < quantity)
                throw new InvalidOperationException("No Books Available Now");

            Stock -= quantity;
            Console.WriteLine($"Shipping {quantity} of '{Title}' to {address} via ShippingService.");
            return Price * quantity;
        }
    }
}
