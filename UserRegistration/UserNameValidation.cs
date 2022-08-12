using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    class UserDetailsValidation
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
        public void ValidateEmail(string emailID)
        {
            string pattern = "^[a-z]+(.[a-z]+)?(@[a-z]+[.][a-z]+)(.[a-z]+)?";
            TestRegex(emailID, pattern);
        }
        public void ValidateMobileNum(string mobileNum)
        {
            string pattern = "^[0-9]{2}[ ][0-9]{10}$";
            TestRegex(mobileNum, pattern);
        }
        public void ValidatePassword(string password)
        {
            string pattern = "(?=.*?[A-Z])(?=.*?[0-9])[0-9a-zA-Z#?!@$%^&*-]{8,}";
            TestRegex(password, pattern);
        }
    }
}
