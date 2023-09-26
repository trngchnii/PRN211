using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot7
{
    internal class UpperLower
    {
        public delegate void MyDelegate(string msg);
        class MyClass
        {
            public static void Print(string message) => Console.WriteLine($"{message.ToUpper()}");
            public static void Show(string message) => Console.WriteLine($"{message.ToLower()}");

        }

        class Program2
        {
            static void InvokeDelegate(MyDelegate dele, string msg) => dele(msg);
            static void Main(string[] args)
            {
                string msg = "Passing Delegate As A Parameter";
                InvokeDelegate(MyClass.Print, msg);
                InvokeDelegate(MyClass.Show, msg);
                Console.ReadLine();
            }
        }
    }
}
