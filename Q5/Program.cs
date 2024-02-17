using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryBook[] books = new LibraryBook[3];

            books[0] = new LibraryBook("Book1", "Author1", true);
            books[1] = new LibraryBook("Book2", "Author2", false);
            books[2] = new LibraryBook("Book3", "Author3", true);

            Console.WriteLine("\nUpdate library status:");
            DisplayLibraryStatus(books);

            Console.ReadLine();
        }

        static void DisplayLibraryStatus(LibraryBook[] books)
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Title:{book.Title},Author:{book.Author},Available:{(book.Available ? "yes" : "no")}");
            }
        }
    }
}

