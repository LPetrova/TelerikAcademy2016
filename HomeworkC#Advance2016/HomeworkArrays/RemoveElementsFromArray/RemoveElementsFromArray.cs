﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElementsFromArray
{ 
    class RemoveElementsFromArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            List<int> newArr = new List<int>();
            int maxSeq = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                newArr.Add(1);//pylnim lista s 1
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if ((arr[j] <= arr[i]) && (newArr[i] < (newArr[j] + 1)))
                    {
                        newArr[i] = newArr[j] + 1;
                        if (maxSeq < newArr[i])
                        {
                            maxSeq = newArr[i];
                        }
                    }
                }
            }
            Console.WriteLine(n - maxSeq);
        }
    }
}
