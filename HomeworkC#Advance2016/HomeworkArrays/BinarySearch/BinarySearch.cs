using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int numberX = int.Parse(Console.ReadLine());

            int counter = 0;
            int start = 0;
            int end = n - 1;
            int result = -1;
            int mid = (end - start) / 2;

            while (counter <= n / 2)
            {
                if (arr[mid] == numberX)
                {
                   result = mid;
                    break;
                }
                else if (arr[mid] > numberX)
                {
                    end = mid - 1;
                    mid = (start + end) / 2;
                    counter++;
                }
                else
                {
                    start = mid + 1;
                    mid = (start + end) / 2;
                    counter++;
                }
            }
            Console.WriteLine(result);

        }
    }
}
