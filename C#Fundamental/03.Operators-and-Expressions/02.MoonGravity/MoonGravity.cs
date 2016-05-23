using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MoonGravity
{
    class MoonGravity
    {
        static void Main(string[] args)
        {
            float weigth = float.Parse(Console.ReadLine());
            float moonGravity = 17 / 100f;
            float result = weigth * moonGravity;
            Console.WriteLine("{0:f3}", result);
        }
    }
}
