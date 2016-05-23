using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ExchangeNumbers
{
    class ExchangeNumbers
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double temp;

            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
                Console.WriteLine("{0} {1}", a, b);
            }
            else
            {
                Console.WriteLine("{0} {1}", a, b);
            }

        }
    }
}
