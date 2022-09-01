using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to Regular Expression Program\n");
            UserDetailsValidation userName = new UserDetailsValidation();

            //Console.WriteLine("Enter First name: ");
            string firstName = null;
            userName.ValidateFirstName(firstName);

            //Console.WriteLine("Enter Last name: ");
            //string lastName = Console.ReadLine();
            //userName.ValidateLastName(lastName);

            //Console.WriteLine("Enter a email ID: ");
            //string emailID = Console.ReadLine();
            //userName.ValidateEmail(emailID);

            //Console.WriteLine("Enter a Mobile number with country code: ");
            //string mobileNum = Console.ReadLine();
            //userName.ValidateMobileNum(mobileNum);

            //Console.WriteLine("Enter password: ");
            //string password = Console.ReadLine();
            //userName.ValidatePassword(password);

            //string[] validInputs= { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" };
            //string[] invalidInputs = { "abc", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com", "abc@%*.com", "abc..2002@gmail.com", "abc.@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
            //userName.ValidateMultipleEmails(validInputs);
            //Console.WriteLine();
            //userName.ValidateMultipleEmails(invalidInputs);

            Console.ReadLine();
        }
    }
}
