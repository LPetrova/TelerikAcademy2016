using System;
using System.Numerics;

namespace _08.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            BigInteger factTwoN = 1;
            BigInteger factN= 1;
            BigInteger factNPlusOne = 1;
            BigInteger result = 1;

            for (ulong i = 1; i <= (2*n); i++)
            {
                factTwoN *= i;
            }

            for (ulong i = 1; i <= n; i++)
            {
                factN *= i;
            }

            for (ulong i = 1; i <= (n+1); i++)
            {
                factNPlusOne *= i;
            }
            result = factTwoN / (factNPlusOne * factN);
            Console.WriteLine(result);
        }
    }
}
