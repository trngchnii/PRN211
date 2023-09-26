using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_3
{
    internal class Recatangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input length: ");
            double length = Double.Parse(Console.ReadLine());
            Console.WriteLine("Input width: ");
            double width = Double.Parse(Console.ReadLine());

            (double perimeter, double area, double smaller) = Rectang(length, width);

            Console.WriteLine("Perimeter: {0}", perimeter);
            Console.WriteLine("Area: {0}", area);
            Console.WriteLine("Smaller side: {0}", smaller);
        }

        static (double, double, double) Rectang(double length, double width)
        {
            double perimeter = (length + width) * 2;
            double area = length * width;
            double smaller = Math.Min(length, width);

            return (perimeter, area, smaller);
        }
    }
}
