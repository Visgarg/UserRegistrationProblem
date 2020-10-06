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
                    Console.WriteLine("Please enter 1st alphabet as capital and min 3 alphabets");
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
                    Console.WriteLine("Please enter 1st alphabet as capital and min 3 alphabets");
                    Console.WriteLine("Please enter the user name again");
                }
            }

        }
        public static void Email()
        {
            UserRegistration userRegistration = new UserRegistration();
            while (true)
            {
                Console.WriteLine("Please enter the user Email for registration");
                string input = Console.ReadLine();
                if (input == "")
                {
                    Console.WriteLine("No email entered");
                    //break;

                }


                bool validationForUserName = userRegistration.Email(input);
                if (validationForUserName)
                {
                    Console.WriteLine($"The email- {input} is valid");
                    break;

                }
                else
                {
                    Console.WriteLine("The name does not match specified condition");
                    Console.WriteLine("Please enter mail id in form of abc.xyz@mnop.com.in");
                    Console.WriteLine("Please enter the email again");
                }
            }
        }
        public static void MobileNo()
        {
            UserRegistration userRegistration = new UserRegistration();
            while (true)
            {
                Console.WriteLine("Please enter the user mobile no for registration");
                string input = Console.ReadLine();
                if (input == "")
                {
                    Console.WriteLine("No mobile no entered");
                    //break;

                }


                bool validationForUserName = userRegistration.MobileNo(input);
                if (validationForUserName)
                {
                    Console.WriteLine($"The mobile no- {input} is valid");
                    break;

                }
                else
                {
                    Console.WriteLine("The mobile no does not match specified condition");
                    Console.WriteLine("Please enter country code, followed by space and 10 digit mobile no");
                    Console.WriteLine("Please enter the mobile no again");
                }
            }
        }
    }
}
