using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = (b * b) - (4 * a * c);

            if (d > 0)
            {
                double x1 = (-b - Math.Sqrt(d)) / (2 * a);
                double x2 = (-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("{0:f2}\n{1:f2}", x1, x2);

            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("{0:f2}", x);
            }
            else
            {
                Console.WriteLine("no real roots");
            }


        }
    }
}
