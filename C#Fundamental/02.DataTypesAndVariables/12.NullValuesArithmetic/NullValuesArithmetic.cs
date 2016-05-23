using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? nullNum = null;
            double? nullDoubleNum = null;
            Console.WriteLine(nullNum);
            Console.WriteLine(nullDoubleNum);

            nullNum = 5;
            nullDoubleNum = 6;
            Console.WriteLine(nullNum);
            Console.WriteLine(nullDoubleNum);
        }
    }
}
