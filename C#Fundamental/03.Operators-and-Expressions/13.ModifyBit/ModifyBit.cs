using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ModifyBit
{
    class ModifyBit
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());

            if (v == 1)
            {
                ulong setOne = (ulong)1 << p;
                ulong bitOne = n | setOne;
                Console.WriteLine(bitOne);
            }
            else
            {
                ulong setZero = (ulong)~(1 << p);
                ulong bitZero = n & setZero;
                Console.WriteLine(bitZero);
            }
           
        }
    }
}
