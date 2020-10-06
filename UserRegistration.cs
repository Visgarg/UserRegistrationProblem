using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    class UserRegistration
    {
        public bool UserPatternMaking(string input)
        {
            string firstNamePattern = "[A-Z]{1}[A-Za-z]{2,}";
            return Regex.IsMatch(input, firstNamePattern);

        }
    }
}
