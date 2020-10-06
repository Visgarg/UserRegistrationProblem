using System;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Please enter the user name for registration");
                string input = Console.ReadLine();
                if (input == "")
                    break;
                UserRegistration userRegistration = new UserRegistration();
                bool validationForUserName = userRegistration.UserPatternMaking(input);
                if(validationForUserName)
                {
                    Console.WriteLine($"The user name- {input} is valid");
                }
                else
                {
                    Console.WriteLine("The name does not match specified condition");
                }
            }
        }
    }
}
