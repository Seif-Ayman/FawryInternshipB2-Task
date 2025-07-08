using FawryInternshipB2_Task.Models;

namespace FawryInternshipB2_Task
{
    class Program
    {
        static void Main()
        {
            var store = new Inventory();

            var paperBook = new PaperBook("EG001", "العطر الفرنسي", 2020, 120, "\nاحمد خالد توفيق", 5);
            var ebook = new EBook("EG002", "Yotobia", 2008, 140, "Dr. Ahmed Khaled Tawfik", "PDF\n");
            var showcase = new ShowcaseBook("SB001", "Quantum Physics Intro", 1995, "Dr. Jane Wells\n");

            store.AddBook(paperBook);
            store.AddBook(ebook);
            store.AddBook(showcase);

            try
            {
                double paid1 = store.BuyBook("EG001", 2, "devseifayman@gmail.com", "123 Fawry City \n");
                Console.WriteLine($"Paid amount: ${paid1} \n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                double paid2 = store.BuyBook("EB001", 1, "ebooklover@example.com\n", null);
                Console.WriteLine($"Quantum book store: Paid amount: ${paid2}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                store.BuyBook("SB001", 1, "demo@example.com", "Smart Village");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Quantum book store: Removing outdated books older than 20 years.");
            store.RemoveOutdatedBooks(20);
        }
    }
}
