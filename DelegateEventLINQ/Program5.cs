using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventLINQ
{
    public delegate void PrintDelegate(string msg);
    class Program5
    {
        event PrintDelegate Print;
        void Show(string msg) => Console.WriteLine(msg.ToUpper());
        static void Main(string[] args)
        {
            Program5 p = new Program5();
            p.Print += new PrintDelegate(p.Show);
            p.Print("Hi!");
            Console.ReadLine();
        }
    }
}
