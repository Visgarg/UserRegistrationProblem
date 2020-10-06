using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    class UserRegistration
    {
        public bool FirstAndLastName(string input)
        {
            string firstNamePattern = "[A-Z]{1}[A-Za-z]{2,}";
            return Regex.IsMatch(input, firstNamePattern);

        }
        public bool Email(string input)
        {
            string emailPattern = @"^[a-z]{1}[a-z0-9]*([._]?[a-z0-9]+)*\@[a-z0-9]+\.(com|net)(\.[a-z]{2})?$";
            return Regex.IsMatch(input, emailPattern);
        }
        public bool MobileNo(string input)
        {
            string mobileNoPattern = @"\d{2}\s{1}[6-9]{1}\d{9}";
            return Regex.IsMatch(input, mobileNoPattern);
        }
        public bool Password(string input)
        {
            //string passwordPattern = "^([A-Z]+[a-z0-9]*){8,}";
            string passwordPattern = @"^(?=.*[A-Z])(?=.*[0-9])[a-zA-Z\d]{8,}$";
            //https://stackoverflow.com/questions/19605150/regex-for-password-must-contain-at-least-eight-characters-at-least-one-number-a
            //https://stackoverflow.com/questions/21197394/what-does-do-in-regex/21197429
            //https://stackoverflow.com/questions/10804732/what-is-the-difference-between-and-in-regex
            return Regex.IsMatch(input, passwordPattern);
        }
    }
}
