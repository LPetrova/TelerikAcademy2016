using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.OddAndEvenNumbers
{
    class OddAndEvenNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] splitNum = input.Split(' ');

            long oddSum = 1;
            long evenSum = 1;


            for (int i = 1; i <= splitNum.Length; i++)
            {
                if (i % 2 == 0)
                {
                    evenSum *= int.Parse(splitNum[i - 1]);
                }
                else
                {
                    oddSum *= int.Parse(splitNum[i - 1]);
                }
            }

            if (evenSum == oddSum)
            {
                Console.WriteLine("yes {0}", evenSum);
            }
            else
            {
                Console.WriteLine("no {0} {1}", oddSum, evenSum);
            }

        }
    }
}
