using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PointInCircle
{
    class PointInCircle
    {
        static void Main(string[] args)
        {
            int radius = 2;
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            
            double pointInCircle = Math.Sqrt(x * x + y * y);

            if (pointInCircle <= 2)
            {
                Console.WriteLine("yes {0:f2}", pointInCircle);
            }
            else
            {
                Console.WriteLine("no {0:f2}", pointInCircle);
            }
        }
    }
}
