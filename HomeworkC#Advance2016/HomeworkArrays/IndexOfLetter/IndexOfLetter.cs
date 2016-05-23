using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetter
{
    class IndexOfLetter
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string[] alphabetArray = new string[26];
            word = word.ToUpper();

            for (int i = 0; i < 26; i++)
            {
                alphabetArray[i] = Convert.ToString(Convert.ToChar(i + 65));
            }

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (Convert.ToString(word[i]) == alphabetArray[j])
                    {
                        Console.WriteLine(j); 
                    }
                }
            }
        }
    }
}
