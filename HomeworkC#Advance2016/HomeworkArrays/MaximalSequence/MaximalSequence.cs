using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSequence
{
    class MaximalSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            arr[0] = int.Parse(Console.ReadLine());
            int maxSequence = 0;
            int currentSequence = 1;

            for (int i = 1; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

                if (arr[i] == arr[i - 1])
                {
                    currentSequence += 1;
                    maxSequence = Math.Max(maxSequence, currentSequence);
                }
                else
                {
                    currentSequence = 1;
                }
            }

            Console.WriteLine(maxSequence);
        }
    }
}
