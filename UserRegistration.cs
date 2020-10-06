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
    }
}
