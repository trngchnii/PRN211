﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Unboxing
    {
        static void Main(string[] args)
        {
            int i = 123;
            object o = i;
            int j = (int)o;
            Console.WriteLine("i={0}, o={1}, j={2}", i,o,j);
            Console.ReadLine();
        }
    }
}
