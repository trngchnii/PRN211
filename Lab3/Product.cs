using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    using System;
    using System.Collections;

    public class Product
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"Product Name: {Name}, Cost: {Cost}, Quantity: {Quantity}";
        }
    }

    class Program1
    {
        static void Main()
        {
            ArrayList productList = new ArrayList()
            {
                new Product { Name = "Iphone6", Cost = 2.11, Quantity = 2},
                new Product { Name = "Iphone6plus", Cost = 12.22, Quantity = 3 },
                new Product { Name = "Iphone12", Cost = 32.2, Quantity = 3 },
                new Product { Name = "Iphone3", Cost = 23, Quantity = 2},
                new Product { Name = "Iphone1", Cost = 4.33, Quantity = 122}

            };
            foreach (Product product in productList)
            {
                Console.WriteLine(product.ToString());
            }
            Console.ReadLine();
        }
    }



}
