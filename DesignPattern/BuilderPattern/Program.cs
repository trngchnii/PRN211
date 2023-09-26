using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Product
    {
        public string PartA { get; set; }
        public string PartB { get; set; }
        public string PartC { get; set; }
    }
    public class ProductBuilder
    {
        private Product product = new Product();

        public ProductBuilder SetPartA(string partA)
        {
            product.PartA = partA;
            return this;
        }

        public ProductBuilder SetPartB(string partB)
        {
            product.PartB = partB;
            return this;
        }

        public ProductBuilder SetPartC(string partC)
        {
            product.PartC = partC;
            return this;
        }

        public Product Build()
        {
            return product;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ProductBuilder builder = new ProductBuilder();

            Product product = builder
                .SetPartA("Part A")
                .SetPartB("Part B")
                .SetPartC("Part C")
                .Build();

            Console.WriteLine($"Part A: {product.PartA}");
            Console.WriteLine($"Part B: {product.PartB}");
            Console.WriteLine($"Part C: {product.PartC}");
        }
    }
}
