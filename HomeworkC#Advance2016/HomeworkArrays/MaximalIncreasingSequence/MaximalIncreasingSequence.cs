using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalIncreasingSequence
{
    class MaximalIncreasingSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            arr[0] = int.Parse(Console.ReadLine());
            int maxIncreasingSequence = 0;
            int currentSequence = 1;

            for (int i = 1; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

                if (arr[i] > arr[i - 1])
                {
                    currentSequence += arr[i];
                    maxIncreasingSequence = Math.Max(maxIncreasingSequence, currentSequence);
                }
                else
                {
                    currentSequence = 1;
                }
            }
            Console.WriteLine(maxIncreasingSequence);
        }
    }
}
