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
            UserNameValidation userName = new UserNameValidation();
            userName.Validation();
            Console.ReadLine();
        }
    }
}
