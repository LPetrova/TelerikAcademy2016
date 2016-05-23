using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            ulong a = 0;
            ulong b = 1;
            ulong fibN;

            if (1 >= n || n <= 50)
            {
                Console.Write("{0}", a);
                for (int i = 1; i < n; i++)
                {                
                    fibN = a + b;
                    a = b;
                    b = fibN;
                    Console.Write(", {0}", a);
                }
                Console.WriteLine();
            }
        }
    }
}
