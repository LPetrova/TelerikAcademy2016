using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ThirdBit
{
    class ThirdBit
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = 3;
            int maskOne = 1;
            int shiftMaskOne = maskOne << p;
            int thirdBit = (shiftMaskOne & n) >> p;
            Console.WriteLine(thirdBit);
        }
    }
}
