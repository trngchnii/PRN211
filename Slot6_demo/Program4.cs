﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventLINQ
{
    class Program4
    {
        static int Sum(int x, int y) => x + y;
        static void Print(string msg) => Console.WriteLine(msg.ToUpper());
        static void Main(string[] args)
        {
            int a = 15, b = 25, s;
            string strResult;
            Func<int, int, int> sumFunc = Sum;
            s = sumFunc(a, b);
            strResult = $"{a} + {b}= {s}";
            Console.WriteLine("**Invoke Print method by Action delegate**");
            Action<string> action = Print;
            action(strResult);
            Console.ReadLine();
        }
    }
}