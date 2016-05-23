using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circle
{
    class Circle
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double PI = Math.PI;
            double area = PI * r * r;
            double perimeter = 2 * PI * r;

            Console.Write("{0:f2} ", area);
            Console.Write("{0:f2}", perimeter);




        }
    }
}
