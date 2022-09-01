using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class UserDetailsValidation
    {
        public string TestRegex(string input,string pattern)
        {

            if (Regex.IsMatch(input, pattern))
            {
                return "valid";
            }
            else
            {
                return "invalid";
            }
        }
        public string ValidateFirstName(string firstName)
        {
            try
            {
                string pattern = "^[A-Z][a-z]{3,}$";
                return TestRegex(firstName, pattern);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Value cannot be null";
            }
        }
        public string ValidateLastName(string lastName)
        {
            try
            {
                string pattern = "^[A-Z][a-z]{2,}$";
                return TestRegex(lastName, pattern);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Value cannot be null";
            }
        }
        public string ValidateEmail(string emailID)
        {
            try
            {
                string pattern = "^[a-z]+(.[a-z]+)?(@[a-z]+[.][a-z]+)(.[a-z]+)?";
                return TestRegex(emailID, pattern);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Value cannot be null";
            }
        }
        public string ValidateMobileNum(string mobileNum)
        {
            try
            {
                string pattern = "^[0-9]{2}[ ][0-9]{10}$";
                return TestRegex(mobileNum, pattern);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Value cannot be null";
            }
        }
        public string ValidatePassword(string password)
        {
            try
            {
                string pattern = "(?=.*[A-Z])(?=.*[0-9])(?=.*[#?!@$%^&*-])[0-9a-zA-Z#?!@$%^&*-]{8,}";
                return TestRegex(password, pattern);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Value cannot be null";
            }
        }
        public void TestMultipleEmails(string[] inputs, string pattern)
        {
            foreach (string input in inputs)
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }
        }
        public string ValidateMultipleEmails(string emails)
        {
            try
            {
                string pattern = "^[0-9a-z]+([._+-][0-9a-z]+)?(@[0-9a-z]+[.][a-z]{2,})(.[a-z]{2,})?$";
                return TestRegex(emails, pattern);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Value cannot be null";
            }
        }
    }
}
