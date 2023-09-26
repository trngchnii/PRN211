using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class ConsoleClass
    {
        static void Main(string[] args)
        {
            double d;
            int i;
            string s;
            DateTime date;
            Console.WriteLine("***** Data Type Parsing *****");
            Console.WriteLine("Enter a String value: ");
            s = Console.ReadLine();
            Console.WriteLine("Enter a Double value: ");
            d = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Integer value: ");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Date value: ");
            date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Value of s:{s}, i: {i}, d:{d}, date:{date: dd/MM/yyyy}");
            Console.ReadLine();
        }
    }
}
