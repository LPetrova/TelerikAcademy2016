using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxKSum
{
    class MaxKSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int maxSumOfKElements = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);
            Array.Reverse(arr);

            for (int i = 0; i < k; i++)
            {
                maxSumOfKElements += arr[i];
            }

            Console.WriteLine(maxSumOfKElements);
        }
    }
}
