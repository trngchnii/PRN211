using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_3
{
    internal class PaternMatching
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input data:");
            int.TryParse(Console.ReadLine(), out int n);
            if (n is int count && count > 0)
            {
                Console.WriteLine(new String('*', count));
            }
            else
            {
                Console.WriteLine("Data invalid");
            }
            Console.ReadLine();
        }
    }
}
