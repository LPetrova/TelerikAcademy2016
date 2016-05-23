using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _16.Trailing0InN
{
    class Trailing0InN
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());
            int count = 1;
            int zeroes = 0;

            while (input / Math.Pow(5, count) >= 1)
            {
                zeroes += input / (int)(Math.Pow(5, count));
                count++;
            }
            Console.WriteLine(zeroes);

            //int n = int.Parse(Console.ReadLine());
            //BigInteger factoriel = 1;
            //BigInteger zero = 0;
            //
            //
            //for (int i = 1; i <= n; i++)
            //{
            //    factoriel *= i;
            //    
            //}
          
           // while (factoriel > 0)
           // {
           //     BigInteger remainder = factoriel % 10;
           //     factoriel /= 10;
           //     if (remainder == 0)
           //     {
           //         zero++;
           //     }
           //     else
           //     {
           //         break;
           //     }              
           // }
            //Console.WriteLine(zero);      
        }
    }
}
