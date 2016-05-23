using System;

class ComparingFloats
{
    static void Main()
    {
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        double abs = Math.Abs(num2 - num1);

        if (abs < eps)
        {
            Console.WriteLine("true");
            
        }
        else
        {
            Console.WriteLine("false");
        }
        
    }
}

