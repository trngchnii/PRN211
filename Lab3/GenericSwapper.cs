using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class GenericSwapper<T>
    {
        public void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }

    class Program4
    {
        static void Main()
        {
            int num1 = 5, num2 = 10;
            string str1 = "Hello", str2 = "World";

            GenericSwapper<int> intSwapper = new GenericSwapper<int>();
            intSwapper.Swap(ref num1, ref num2);
            Console.WriteLine($"Swapped integers: {num1}, {num2}");

            GenericSwapper<string> stringSwapper = new GenericSwapper<string>();
            stringSwapper.Swap(ref str1, ref str2);
            Console.WriteLine($"Swapped strings: {str1}, {str2}");
        }
    }
}
