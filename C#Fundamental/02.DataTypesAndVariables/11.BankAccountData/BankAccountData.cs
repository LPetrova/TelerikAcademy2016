using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BankAccountData
{
    class BankAccountData
    {
        static void Main(string[] args)
        {
            string firstName = "Didi";
            string middleName = "Ivanova";
            string lastName = "Petrova";
            object fullName = firstName + " " + middleName + " " + lastName;
            decimal balance = 438728952.1m;
            string bankName = "Unibank";
            string iban = "BG80BNBG96611020345678";
            string bic = "STSABGSF";
            ulong creditCardNumber1 = 123656780001134u;
            ulong creditCardNumber2 = 123656780001334u;
            ulong creditCardNumber3 = 123656780002134u;
            Console.WriteLine(
                "Account holder: " + fullName
                + "\nBalance: " + balance
                + "\nBank name: " + bankName
                + "\nIBAN" + iban
                + "\nBIC: " + bic 
                + "\n Credit cart 1: " + creditCardNumber1
                + "\n Credit cart 1: " + creditCardNumber2
                + "\n Credit cart 1: " + creditCardNumber3);
        }
    }
}
