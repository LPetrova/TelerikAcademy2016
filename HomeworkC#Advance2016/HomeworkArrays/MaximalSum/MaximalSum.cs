using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaximalSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        int currentMax = 1;
        int maxSoFar = 0;

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arr.Length; i++)
        {

            currentMax = Math.Max(0, currentMax + arr[i]);

            maxSoFar = Math.Max(maxSoFar, currentMax);

            if (currentMax >= maxSoFar)
            {
                maxSoFar = currentMax;
            }
        }

        Console.WriteLine(maxSoFar);
    }
}

