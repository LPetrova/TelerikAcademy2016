using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MMASOfNumbers
{
    class MMASOfNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double max = double.MinValue;
            double min = double.MaxValue;         
            double sum = 0;
            double currentNum;

            for (int i = 0; i < n; i++)
            {
                currentNum = double.Parse(Console.ReadLine());
                sum += currentNum;

                if (currentNum < min)
                {
                    min = currentNum;
                }
                if(currentNum > max)
                {
                    max = currentNum;
                }
            }
            Console.WriteLine("min={0:f2}", min);
            Console.WriteLine("max={0:f2}", max);
            Console.WriteLine("sum={0:f2}", sum);
            Console.WriteLine("avg={0:f2}", sum / n);
        }
    }
}
