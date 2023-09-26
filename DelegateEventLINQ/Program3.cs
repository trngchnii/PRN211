using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventLINQ
{
    public delegate void MyDelegate(string msg);
    class MyClass
    {
        public static void Print(string message) => Console.WriteLine($"{message.ToUpper()}");
        public static void Show(string message) => Console.WriteLine($"{message.ToLower()}");
        public static void Display(string message) => Console.WriteLine($"{message}");
    }

    class Program3
    {
        static void Main(string[] args)
        {
            string msg = "Multicast Delegate";
            MyDelegate MyDele01 = MyClass.Print;
            MyDelegate MyDele02 = MyClass.Show;
            Console.WriteLine("**Combines MyDele01 + MyDele02**");
            MyDelegate MyDele = MyDele01 + MyDele02;
            MyDele(msg);
            Console.WriteLine("**Combines MyDele01 + MyDele02 + MyDele03**");
            MyDelegate MyDele03 = MyClass.Display;
            MyDele += MyDele03;
            MyDele(msg);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("**Remove MyDele02**");
            MyDele03 -= MyDele02;
            MyDele("HelloWorld!");
            Console.ReadLine();
        }
    }
}
