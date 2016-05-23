using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PrintSequence
{
    class PrintSequence
    {
        static void Main()
        {
            int numberOfLoops = 11;

            for (int i = 2; i <= 11; i++)
            {
                int result = i;

                if (result % 2 != 0)
                {
                    result = -i;
                }
                Console.WriteLine(result);
            }
        }
    }
}
