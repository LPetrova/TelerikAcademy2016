using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            string firstArrayLength = Console.ReadLine();
            char[] firstArray = firstArrayLength.ToCharArray();
            string secondArrayLength = Console.ReadLine();
            char[] secondArray = secondArrayLength.ToCharArray();
 
            bool equal = false;
            int i = 0;
            int j = 0;

            while (i < firstArray.Length && j < secondArray.Length)
            {
                if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine(">");
                    equal = false;
                    break;
                }
                else if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("<");
                    equal = false;
                    break;
                }
                else
                {
                    equal = true;
                }
                i++;
                j++;
            }

            if (equal == true)
            {
                if (firstArray.Length < secondArray.Length)
                {
                    Console.WriteLine("<");
                }
                else if (firstArray.Length > secondArray.Length)
                {
                    Console.WriteLine(">");
                }
                else
                {
                    Console.WriteLine("=");
                }
            }
        }
    }
}
