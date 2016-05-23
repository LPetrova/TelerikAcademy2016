using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.HexToDecimal
{
    class HexToDecimal
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            long dec = 0;

            for (int i = 0; i < hex.Length; i++)
            {
                switch (hex[i])
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':

                        dec += long.Parse(hex[i].ToString()) * (long)Math.Pow(16, hex.Length - 1 - i);
                        break;
                    case 'A':
                        dec += 10 * (long)Math.Pow(16, hex.Length - 1 - i);
                        break;
                    case 'B':
                        dec += 11 * (long)Math.Pow(16, hex.Length - 1 - i);
                        break;
                    case 'C':
                        dec += 12 * (long)Math.Pow(16, hex.Length - 1 - i);
                        break;
                    case 'D':
                        dec += 13 * (long)Math.Pow(16, hex.Length - 1 - i);
                        break;
                    case 'E':
                        dec += 14 * (long)Math.Pow(16, hex.Length - 1 - i);
                        break;
                    case 'F':
                        dec += 15 * (long)Math.Pow(16, hex.Length - 1 - i);
                        break;
                }
            }
            Console.WriteLine(dec);

        }
    }
}
