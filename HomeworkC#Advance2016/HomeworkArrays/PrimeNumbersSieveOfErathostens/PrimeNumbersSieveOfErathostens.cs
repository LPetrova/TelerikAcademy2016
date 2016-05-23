using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbersSieveOfErathostens
{
    class PrimeNumbersSieveOfErathostens
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] flag = new bool[n];

            for (int i = 2; i < n; i++)
            {
                flag[i] = true;
            }

            for (int i = 2; i < n; i++)
            {
                if (flag[i] == true)
                {
                    int j = i + 1;

                    while (j <= n)
                    {
                        if (j % i == 0)
                        {
                            flag[j] = false; 
                        }
                        j++;
                    }
                }
            }

            for (int i = 2; i < n; i++)
            {
                if (flag[i] == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
