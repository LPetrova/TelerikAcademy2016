using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.BitExchange
{
    class BitExchange
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());

            int bitAtPosition3 = TakeABit(number, 3);
            int bitAtPosition4 = TakeABit(number, 4);
            int bitAtPosition5 = TakeABit(number, 5);
            int bitAtPosition24 = TakeABit(number, 24);
            int bitAtPosition25 = TakeABit(number, 25);
            int bitAtPosition26 = TakeABit(number, 26);

            number = ModifiedNumber(number, 3, bitAtPosition24);
            number = ModifiedNumber(number, 4, bitAtPosition25);
            number = ModifiedNumber(number, 5, bitAtPosition26);
            number = ModifiedNumber(number, 24, bitAtPosition3);
            number = ModifiedNumber(number, 25, bitAtPosition4);
            number = ModifiedNumber(number, 26, bitAtPosition5);

            Console.WriteLine(number);

        }

        private static int TakeABit(uint number, int position)
        {
            uint pthBit = (number >> position) & 1;
            return (int)pthBit;
        }

        private static uint ModifiedNumber(uint number, int position, int bitValue)
        {
            uint actualP = (uint)bitValue << position;
            number = number & (~((uint)1 << position));
            uint result = number | actualP;
            return result;
        }
    }
}
