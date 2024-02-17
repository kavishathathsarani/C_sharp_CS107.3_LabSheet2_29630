using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            product product1 = new product("Smart Phone", 120000.00);

            Console.WriteLine(product1.ProductName);
            Console.WriteLine(product1.Price);

            

            Console.ReadLine();
        }

        
    }
}
