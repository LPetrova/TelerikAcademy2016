using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            int decNum = int.Parse(Console.ReadLine());

            int remainder;
            string result = string.Empty;

            while (decNum > 0)
            {
                remainder = decNum % 2;
                decNum /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine(result);
        }
    }
}
