using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Age
{
    class Age
    {
        static void Main()
        {
            string myBirthDay = Console.ReadLine();
            DateTime realBirthDay = DateTime.Parse(myBirthDay);
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - realBirthDay.Year;

            if (currentDate < realBirthDay.AddYears(age))
            {
                age--;
            }
            Console.WriteLine(age);
            Console.WriteLine(age + 10);
            
        }
    }
}
