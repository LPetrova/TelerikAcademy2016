using System;

class ThirdDigit
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int divideToHundred = n % 1000;
        int digit = divideToHundred / 100;

        if ((digit % 7 == 0) && (digit != 0))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false {0}", digit);
        }     
    }
}

