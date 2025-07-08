using FawryInternshipB2_Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryInternshipB2_Task
{
    public class Inventory
    {
        private readonly Dictionary<string, Book> _books = new();

        public void AddBook(Book book)
        {
            _books[book.ISBN] = book;
            Console.WriteLine($"Quantum book store: Book '{book.Title}' added to inventory.");
        }

        public void RemoveOutdatedBooks(int maximumyear)
        {
            var toRemove = new List<string>();

            foreach (var book in _books)
            {
                if (book.Value.isOutdated(maximumyear))
                    toRemove.Add(book.Key);
            }

            foreach (var isbn in toRemove)
            {
                Console.WriteLine($"Quantum book store: Removing outdated book ISBN: {isbn}");
                _books.Remove(isbn);
            }
        }

        public double BuyBook(string isbn, int quantity, string email, string address)
        {
            if (!_books.TryGetValue(isbn, out var book))
                throw new ArgumentException("Quantum book store: Book not found.");

            return book.Buy(quantity, email, address);
        }
    }
}
