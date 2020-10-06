using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationProblem
{
    class UserDetailsEntry
    {
        public static void FirstName()
        {
            UserRegistration userRegistration = new UserRegistration();
            while (true)
            {
                Console.WriteLine("Please enter the user first name for registration");
                string input = Console.ReadLine();
                if (input == "")
                {
                    Console.WriteLine("No user name entered");

                }


                bool validationForUserName = userRegistration.FirstAndLastName(input);
                if (validationForUserName)
                {
                    Console.WriteLine($"The user name- {input} is valid");
                    break;
                }
                else
                {
                    Console.WriteLine("The name does not match specified condition");
                    Console.WriteLine("Please enter the user name again");
                }
            }
        }
        public static  void LastName()
        {
            UserRegistration userRegistration = new UserRegistration();
            while (true)
            {
                Console.WriteLine("Please enter the user last name for registration");
                string input = Console.ReadLine();
                if (input == "")
                {
                    Console.WriteLine("No user name entered");

                }


                bool validationForUserName = userRegistration.FirstAndLastName(input);
                if (validationForUserName)
                {
                    Console.WriteLine($"The last name- {input} is valid");

                    break;
                }
                else
                {
                    Console.WriteLine("The name does not match specified condition");
                    Console.WriteLine("Please enter the user name again");
                }
            }

        }
    }
}
