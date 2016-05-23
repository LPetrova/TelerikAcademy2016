using System;


namespace _05.Calculate
{
    class Calculate
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            double facturiel = 1;
            double result = 1 + 1/x;
            double power = 0;

            for (ulong i = 2; i <= n; i++)
            {
                facturiel *= i;
                power = Math.Pow(x, i);
                result += facturiel / power;
            }
            Console.WriteLine("{0:f5}", result);
      
        }
    }
}
