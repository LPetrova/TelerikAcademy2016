﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ExchangeVariableValue
{
    class ExchangeVariableValue
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("a = {0} b = {1} before change", a, b);

            int c = a;
            a = b;
            b = c;
       
            Console.WriteLine("a = {0} b = {1} after change", a, b);


        }
    }
}
