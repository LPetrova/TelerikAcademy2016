using System;
using System.Numerics;

namespace _06.CalculateAgain
{
    class CalculateAgain
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            ulong k = ulong.Parse(Console.ReadLine());
            BigInteger factNK = 1;

            while ((n - k) >= 1)
            {
                factNK *= n;
                n--;
            }

            Console.WriteLine(factNK);
        }
    }
}
