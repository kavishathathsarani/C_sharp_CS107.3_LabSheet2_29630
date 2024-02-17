using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class LibraryBook
    {
        public string Title;
        public string Author;
        public bool Available;

        public LibraryBook(string title, string author, bool available)
        {
            Title = title;
            Author = author;
            Available = available;
        }
        public void BorrowBook()
        {
            if (Available)
            {
                Available = false;
                Console.WriteLine($"You have borrowed '{Title}' by {Author} ");
            }
            else
            {
                Console.WriteLine($"Sorry, '{Title}' by {Author} is currently not available ");
            }
        }
    }
}
