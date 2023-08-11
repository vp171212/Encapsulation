using ProductApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {   Product product1 = new Product(100,"Shirt",1200,25);
            Console.WriteLine(product1.PrintDetails());
            Console.WriteLine("Discounted Price: "+product1.DiscountedPrice());
            Product product2 = new Product(101,"T-shirt",200,18);
            Console.WriteLine(product2.PrintDetails());
            Console.WriteLine("Discounted Price: " + product2.DiscountedPrice());
        }
    }
}
