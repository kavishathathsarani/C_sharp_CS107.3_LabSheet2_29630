using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace c_lab8
{
    internal class Book
    {
        static void Main(string[] args)
        {
            Books book = new Books();
            book.Author = "Arita Desai";
            book.Title = "Village by the sea";

            Console.WriteLine("Title " + book.Title);
            Console.WriteLine("Author " + book.Author);

            Console.ReadLine();

        }
    }
}
