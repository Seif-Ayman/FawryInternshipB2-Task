using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryInternshipB2_Task.Models
{
    public class ShowcaseBook : Book
    {
        public ShowcaseBook(string isbn, string title, int year, string author)
            : base(isbn, title, year, 0.0, author)
        {
        }

        public override double Buy(int quantity, string email, string address)
        {
            throw new InvalidOperationException("Quantum book store: Showcase books are not for sale.");
        }
    }
}
