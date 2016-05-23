using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.DecimalToHex
{
    class DecimalToHex
    {
        static void Main(string[] args)
        {
             long decNum = long.Parse(Console.ReadLine());

             string result = "";

             while (decNum !=  0)
             {
                 if ((decNum % 16) < 10)
                 {
                     result = decNum % 16 + result;

                 }
                 else
                 {
                     string temp = "";

                     switch (decNum % 16)
                     {
                         case 10: temp = "A";
                             break;
                         case 11: temp = "B";
                             break;
                         case 12: temp = "C";
                             break;
                         case 13: temp = "D";
                             break;
                         case 14: temp = "E";
                             break;
                         case 15: temp = "F";
                             break;

                     }
                     result = temp + result;
                 }
                 decNum /= 16;
             }
             Console.WriteLine(result);
        }
    }
}
