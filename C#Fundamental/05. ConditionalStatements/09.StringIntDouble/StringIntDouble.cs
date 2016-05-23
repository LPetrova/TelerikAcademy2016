using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.StringIntDouble
{
    class StringIntDouble
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "integer":
                    int integer = int.Parse(Console.ReadLine());
                    Console.WriteLine(integer + 1);
                    break;
                case "real":
                    double real = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", real + 1);
                    break;
                case "text":
                    string text = Console.ReadLine();
                    Console.WriteLine("{0}*", text);
                    break;
            }
        }
    }
}
