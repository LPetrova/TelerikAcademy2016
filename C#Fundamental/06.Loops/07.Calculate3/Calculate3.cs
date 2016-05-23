using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _07.Calculate3
{
    class Calculate3
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            ulong k = ulong.Parse(Console.ReadLine());
            BigInteger factN = 1;
            BigInteger factK = 1;
            BigInteger factNMinusK = 1;

            BigInteger result = 1;

            //while ((n-k)>=1)
            //{
            //    factNAndK *= n;
            //    n--;
            //}
            for (ulong i = 1; i <= n; i++)
            {
                factN *= i;
            }
            for (ulong i = 1; i <= k; i++)
            {
                factK *= i;
            }
            for (ulong i = 1; i <= (n - k); i++)
            {
                factNMinusK *= i;
            }

            result = factN/(factK * factNMinusK);
            Console.WriteLine(result);
        }
    }
}
