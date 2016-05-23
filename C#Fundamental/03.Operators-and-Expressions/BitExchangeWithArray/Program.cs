using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitExchangeWithArray
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            string numberAsBinary = Convert.ToString(number, 2).PadLeft(64, '0');
            var binaryArray = numberAsBinary.ToCharArray();
            Array.Reverse(binaryArray);

            char temp = binaryArray[3];
            binaryArray[3] = binaryArray[24];
            binaryArray[24] = temp;

            char temp2 = binaryArray[4];
            binaryArray[4] = binaryArray[25];
            binaryArray[25] = temp2;
            

            char tepm3 = binaryArray[5];
            binaryArray[5] = binaryArray[26];
            binaryArray[26] = tepm3;

            Array.Reverse(binaryArray);
            string result = new string(binaryArray);
            long finalResult = Convert.ToInt64(result, 2);
            Console.WriteLine(finalResult);
        }
    }
}
