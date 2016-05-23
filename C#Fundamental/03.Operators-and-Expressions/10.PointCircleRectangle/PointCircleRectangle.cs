using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PointCircleRectangle
{
    class PointCircleRectangle
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double radius = 1.5;
            double centerX = 1;
            double centerY = 1;

            bool isPointInCircle = ((x - centerX) * (x - centerX)) + ((y - centerY) * (y - centerY)) <= radius * radius;
            bool isPointInRectangle = (x >= -1 && x <= 5) && (y <= 1 && y >= -1);

            if (isPointInCircle)
            {
                Console.Write("inside circle ");
            }
            else
            {
                Console.Write("outside circle ");
            }

            if (isPointInRectangle)
            {
                Console.WriteLine("inside rectangle");
            }
            else
            {
                Console.WriteLine("outside rectangle");
            }
        }
    }
}
