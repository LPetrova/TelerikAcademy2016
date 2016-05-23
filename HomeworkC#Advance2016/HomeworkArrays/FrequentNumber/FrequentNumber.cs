using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequentNumber
{
    class FrequentNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int tempCounter = 1;
            int counter = 0;
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            //sledim za povtarq6ti elemnti
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        tempCounter ++;
                    }
                }
                //nai dobriq rezultat go zapisvame v druga promenliva
                if (tempCounter > counter)
                {
                    counter = tempCounter;
                    index = i;
                }
                tempCounter = 0;
            }
            Console.WriteLine("{0} ({1} times)", arr[index], counter);
        }
    }
}
