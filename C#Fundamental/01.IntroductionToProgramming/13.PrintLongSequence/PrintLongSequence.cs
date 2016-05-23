using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main()
        {
            int startNum = 2;
            int endNum = 1002;
            for (int i = startNum; i < endNum; i++)
            {
                int result = i;

                if (i % 2 != 0)
                {
                    result = -i;
                }
                Console.WriteLine(result);
            }
        }
    }
}
