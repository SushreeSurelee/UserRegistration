using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    class UserNameValidation
    {
        public void TestRegex(string input, string pattern)
        {

            if (Regex.IsMatch(input, pattern))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void Validation()
        {
            Console.WriteLine("Enter the user name");
            string input = Console.ReadLine();
            string pattern = "^[A-Z][a-z]{2}";
            TestRegex(input, pattern);
        }
    }
}
