using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isprime = true;
            List<int> primeNum = new List<int>();
            int biggestPrimeNum = 0;

            for (int i = 0; i <= n; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isprime = false;
                        break;
                    }                   
                }
                if (isprime)
                {
                    primeNum.Add(i);
                }
                isprime = true;
            }

            for (int i = 0; i < primeNum.Count; i++)
            {
                biggestPrimeNum = primeNum[primeNum.Count - 1];
            }

            Console.WriteLine(biggestPrimeNum);
        }
    }
}
