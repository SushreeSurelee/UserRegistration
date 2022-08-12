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
            UserNameValidation userName = new UserNameValidation();
            Console.WriteLine("Enter First name: ");
            string firstName = Console.ReadLine();
            userName.ValidateFirstName(firstName);
            
            Console.WriteLine("Enter Last name: ");
            string lastName = Console.ReadLine();
            userName.ValidateFirstName(lastName);

            Console.WriteLine("Enter a email ID: ");
            string emailID = Console.ReadLine();
            userName.ValidateEmail(emailID);
            Console.ReadLine();


        }
    }
}
