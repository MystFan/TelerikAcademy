﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}, b = {1}",a,b);
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("After:");
            Console.WriteLine("a = {0}, b = {1}", a, b);
        }
    }
}
