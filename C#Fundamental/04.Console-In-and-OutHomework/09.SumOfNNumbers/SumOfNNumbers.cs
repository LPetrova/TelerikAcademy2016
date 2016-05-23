using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double n;
            double result = 0;

            for (int i = 1; i <= length; i++)
            {
                n = double.Parse(Console.ReadLine());
                result += n;
            }
            Console.WriteLine(result);

        }
    }
}
