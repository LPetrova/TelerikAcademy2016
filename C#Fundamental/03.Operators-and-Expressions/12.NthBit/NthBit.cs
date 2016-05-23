using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.NthBit
{
    class NthBit
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            long maskOne = 1;
            long bit = n >> p;
            long result = bit & maskOne;
            Console.WriteLine(result);
           
        }
    }
}
