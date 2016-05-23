using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OddOrEven
{
    class OddOrEven
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("even {0}", n);
            }
            else
            {
                Console.WriteLine("odd {0}", n);
            }
        }
    }
}
