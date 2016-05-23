using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSumIn_Array
{
    class FindSumInArray
    {
        static void Main(string[] args)
        {    //въведени числа на конзолата, разделени чрез запетая писледвана от интервал.
            int sum = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] arr = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int start = 0;
            int end = 0;
            int currSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                currSum = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (currSum == sum)
                    {
                        start = i;
                        end = j;                                      
                    }
                    if (currSum > sum || j == sum)
                    {
                        break;
                    }
                    currSum = currSum + arr[j];
                }
            }
            foreach (var n in arr)
            {
                for (int i = start; i < end; i++)
                {
                    Console.Write(arr[i]);

                    if (i < end - 1)
                    {
                        Console.Write(", ");
                    }
        
                }
                break;
            }                      
        }
    }
}
