using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistration;

namespace UserRegistrationTestProject
{
    [TestClass]
    public class UserRegistrationTestClass
    {
        [TestMethod]
        [DataRow("Nikki","valid")]
        [DataRow("N", "invalid")]
        [DataRow("nikki", "invalid")]
        [DataRow("Nikki1", "invalid")]
        public void ShouldCheckForValidFirstName(string msg,string expected)
        {
            UserDetailsValidation userDetailsValidation = new UserDetailsValidation();

            string actual = userDetailsValidation.ValidateFirstName(msg);

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        [DataRow("Sahu", "valid")]
        [DataRow("S", "invalid")]
        [DataRow("sahu", "invalid")]
        [DataRow("Sahu1", "invalid")]
        public void ShouldCheckForValidLastName(string msg, string expected)
        {
            UserDetailsValidation userDetailsValidation = new UserDetailsValidation();

            string actual = userDetailsValidation.ValidateLastName(msg);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("91 3454345434", "valid")]
        [DataRow("4543234323", "invalid")]
        [DataRow("1 4565456456", "invalid")]
        [DataRow("92 45345", "invalid")]
        public void ShouldCheckForValidMobileNumber(string msg, string expected)
        {
            UserDetailsValidation userDetailsValidation = new UserDetailsValidation();

            string actual = userDetailsValidation.ValidateMobileNum(msg);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("abc2@#12A", "valid")]
        [DataRow("abc2@#12a", "invalid")]
        [DataRow("abc@#Afsf", "invalid")]
        [DataRow("abc12Afsf", "invalid")]
        [DataRow("ABC12@Afsf", "valid")]
        public void ShouldCheckForValidPassword(string msg, string expected)
        {
            UserDetailsValidation userDetailsValidation = new UserDetailsValidation();

            string actual = userDetailsValidation.ValidatePassword(msg);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("abc@yahoo.com", "valid")]
        [DataRow("abc-100@yahoo.com","valid")]
        [DataRow("abc.100@yahoo.com", "valid")]
        [DataRow("abc111@abc.com", "valid")]
        [DataRow("abc-100@abc.net", "valid")]
        [DataRow("abc.100@abc.com.au", "valid")]
        [DataRow("abc@1.com", "valid")]
        [DataRow("abc+100@gmail.com", "valid")]
        [DataRow("abc@gmail.com.com", "valid")]
        [DataRow("abc", "invalid")]
        [DataRow("abc@.com.my", "invalid")]
        [DataRow("abc123@gmail.a", "invalid")]
        [DataRow("abc123@.com", "invalid")]
        [DataRow("abc123@.com.com", "invalid")]
        [DataRow(".abc@abc.com", "invalid")]
        [DataRow("abc()*@gmail.com", "invalid")]
        [DataRow("abc@%*.com", "invalid")]
        [DataRow("abc..2002@gmail.com", "invalid")]
        [DataRow("abc.@gmail.com", "invalid")]
        [DataRow("abc@abc@gmail.com", "invalid")]
        [DataRow("abc@gmail.com.1a", "invalid")]
        [DataRow("abc@gmail.com.aa.au", "invalid")]
        public void ShouldCheckForValidandInvalidEmails(string msg,string expected)
        {
            UserDetailsValidation userDetailsValidation = new UserDetailsValidation();

            string actual = userDetailsValidation.ValidateMultipleEmails(msg);

            Assert.AreEqual(expected, actual);
        }
    }
}
