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
            //string firstName = Console.ReadLine();
            //userName.ValidateFirstName(firstName);

            //Console.WriteLine("Enter Last name: ");
            //string lastName = Console.ReadLine();
            //userName.ValidateFirstName(lastName);

            //Console.WriteLine("Enter a email ID: ");
            //string emailID = Console.ReadLine();
            //userName.ValidateEmail(emailID);

            //Console.WriteLine("Enter a Mobile number with country code: ");
            //string mobileNum = Console.ReadLine();
            //userName.ValidateMobileNum(mobileNum);

            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();
            userName.ValidatePassword(password);

            Console.ReadLine();


        }
    }
}
