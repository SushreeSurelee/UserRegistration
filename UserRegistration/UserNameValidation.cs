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
        public void TestRegex(string input,string pattern)
        {
            if (Regex.IsMatch(input, pattern))
            {
                Console.WriteLine("Valid\n");
            }
            else
            {
                Console.WriteLine("Invalid\n");
            }
        }
        public void ValidateFirstName(string firstName)
        {
            string pattern = "^[A-Z][a-z]{2}";
            TestRegex(firstName, pattern);
        }
        public void ValidateLastName(string lastName)
        {
            string pattern = "^[A-Z][a-z]{2}";
            TestRegex(lastName, pattern);
        }
    }
}
