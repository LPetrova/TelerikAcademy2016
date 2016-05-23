using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrimeCheck
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double maxDivider = Math.Sqrt(n);
        bool isPrime = true;

        if ((n <= 1) || (n > 100))
        {
            isPrime = false;
        }

        for (int i = 2; i <= maxDivider; i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
            }
        }

        if (isPrime == true)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }

    }
}