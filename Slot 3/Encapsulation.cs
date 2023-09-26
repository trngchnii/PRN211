using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_3
{
    internal class Encapsulation
    {
        class Customer
        {
            public int CustomerID
            {
                get; set;
            }
            public string CustomerName { get; set; } = "New customer";
            public void Print()
            {
                Console.WriteLine($"ID:{CustomerID}, Name: {CustomerName}");
            }
            static void Main(string[] args)
            {
                Customer obj = new Customer();
                obj.CustomerID = 1000;
                Console.WriteLine($"ID: {obj.CustomerID}, Name: {obj.CustomerName}");
                obj.CustomerID = 2000;
                obj.CustomerName = "Jack";
                obj.Print();
                Console.ReadLine();
            }
        }
    }
}
