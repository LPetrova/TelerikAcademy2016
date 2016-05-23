using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FourDigit
{
    class FourDigit
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int firstNum = ((num / 1000) % 10);
            int secondNum = ((num / 100) %10);
            int thirdNum = ((num / 10) % 10);
            int fourthNum = num % 10;
            int sum = firstNum + secondNum + thirdNum + fourthNum;
            Console.WriteLine(sum);
            Console.WriteLine("{0}{1}{2}{3}", fourthNum, thirdNum, secondNum, firstNum);
            Console.WriteLine("{0}{1}{2}{3}", fourthNum, firstNum, secondNum, thirdNum);
            Console.WriteLine("{0}{1}{2}{3}", firstNum, thirdNum, secondNum, fourthNum);
           
            
        }
    }
}
