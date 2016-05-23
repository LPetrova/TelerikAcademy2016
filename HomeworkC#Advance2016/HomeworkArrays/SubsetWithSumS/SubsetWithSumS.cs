using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsetWithSumS
{
    class SubsetWithSumS
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            int[] arr = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int sum = int.Parse(Console.ReadLine());
            int currentSum = 0;
            bool haveSum = true;

            for (int i = 0; i < arr.Length; i++)
            {
                currentSum = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (currentSum == sum)
                    {
                        haveSum = true;
                    }
                    if (currentSum > sum || j == sum)
                    {
                        haveSum = false;
                        break;
                    }
                    currentSum = currentSum + arr[j];
                }
            }

            if (haveSum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
