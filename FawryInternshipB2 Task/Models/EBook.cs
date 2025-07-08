using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryInternshipB2_Task.Models
{
    public class EBook : Book
    {
        public string FileType { get; }

        public EBook(string isbn, string title, int year, double price, string author, string fileType)
            : base(isbn, title, year, price, author)
        {
            FileType = fileType;
        }

        public override double Buy(int quantity, string email, string address)
        {
            if (quantity != 1)
                throw new InvalidOperationException("You can only aquire 1 ebook of each book");

            Console.WriteLine($"Ebook '{Title}' Sent to {email} via MailService.");
            return Price;
        }
    }
}
