using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationProblem
{
    class UserDetailsEntry
    {
        /// <summary>
        /// Takes input for first name and instatiates class to match with pattern.
        /// </summary>
        public static void FirstName()
        {
            UserRegistration userRegistration = new UserRegistration();
            while (true)
            {
                Console.WriteLine("Please enter the user first name for registration");
                string input = Console.ReadLine();
                if (input == "")
                {
                    //no user name is entered
                    Console.WriteLine("No user name entered");
                    break;

                }


                bool validationForUserName = userRegistration.FirstAndLastName(input);
                if (validationForUserName)
                {
                    //user name matches with the pattern
                    Console.WriteLine($"The user name- {input} is valid");
                    Console.WriteLine("Do you want to check again, press y to check");
                    string check = Console.ReadLine();
                    if (check.ToLower() != "y")
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("The name does not match specified condition");
                    Console.WriteLine("Please enter 1st alphabet as capital and min 3 alphabets");
                    //Console.WriteLine("Please enter the user name again");
                    Console.WriteLine("Do you want to check again, press y to check");
                    string check = Console.ReadLine();
                    if (check.ToLower() != "y")
                    {
                        break;
                    }
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
                    Console.WriteLine("Do you want to check again, press y to check");
                    string check = Console.ReadLine();
                    if (check.ToLower() != "y")
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("The name does not match specified condition");
                    Console.WriteLine("Please enter 1st alphabet as capital and min 3 alphabets");
                    //Console.WriteLine("Please enter the user name again");
                    Console.WriteLine("Do you want to check again, press y to check");
                    string check = Console.ReadLine();
                    if (check.ToLower() != "y")
                    {
                        break;
                    }
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
                    break;

                }


                bool validationForUserName = userRegistration.Email(input);
                if (validationForUserName)
                {
                    Console.WriteLine($"The email- {input} is valid");
                    Console.WriteLine("Do you want to check again, press y to check");
                    string check = Console.ReadLine();
                    if (check.ToLower() != "y")
                    {
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("The name does not match specified condition");
                    Console.WriteLine("Please enter mail id in form of abc.xyz@mnop.com.in");
                    //Console.WriteLine("Please enter the email again");
                    //Console.WriteLine("Do you want to check again");
                    Console.WriteLine("Do you want to check again, press y to check");
                    string check = Console.ReadLine();
                    if (check.ToLower() != "y")
                    {
                        break;
                    }

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
                    break;

                }


                bool validationForUserName = userRegistration.MobileNo(input);
                if (validationForUserName)
                {
                    Console.WriteLine($"The mobile no- {input} is valid");
                    Console.WriteLine("Do you want to check again, press y to check");
                    string check = Console.ReadLine();
                    if (check.ToLower() != "y")
                    {
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("The mobile no does not match specified condition");
                    Console.WriteLine("Please enter country code, followed by space and 10 digit mobile no");
                    //Console.WriteLine("Please enter the mobile no again");
                    Console.WriteLine("Do you want to check again, press y to check");
                    string check = Console.ReadLine();
                    if (check.ToLower() != "y")
                    {
                        break;
                    }
                }
            }
        }
        public static void Password()
        {
            UserRegistration userRegistration = new UserRegistration();
            while (true)
            {
                Console.WriteLine("Please enter the password for registration");
                string input = Console.ReadLine();
                if (input == "")
                {
                    Console.WriteLine("No password entered");
                    break;

                }


                bool validationForUserName = userRegistration.Password(input);
                if (validationForUserName)
                {
                    Console.WriteLine($"The password- {input} is valid");
                    //break;
                    Console.WriteLine("Do you want to check again, press y to check");
                    string check = Console.ReadLine();
                    if (check.ToLower() != "y")
                    {
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("The password does not match specified condition");
                    Console.WriteLine("Please enter country code, followed by space and 10 digit mobile no");
                    //Console.WriteLine("Please enter the password again");
                    Console.WriteLine("Do you want to check again, press y to check");
                    string check = Console.ReadLine();
                    if (check.ToLower() != "y")
                    {
                        break;
                    }
                }
            }
        }
        
    }
}
