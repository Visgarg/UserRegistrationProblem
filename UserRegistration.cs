﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class UserRegistration
    {
        /// <summary>
        /// takes pattern for first name and last name.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool FirstAndLastName(string input)
        { 
                //pattern for first name and last name
                //matches pattern with input and returns bool value.
                string firstNamePattern = "[A-Z]{1}[A-Za-z]{2,}";
                if (Regex.IsMatch(input, firstNamePattern))
                {
                    return true;
                }
                else
                {
                    throw new  UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.invalid_name, "invalid name");
                }
  
        }
        /// <summary>
        /// Emails the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        /// <exception cref="UserRegistrationProblem.UserRegistrationCustomException">
        /// email can not be empty or null
        /// or
        /// email can not be empty or null
        /// </exception>
       public bool Email(string input)
        {

            //pattern for mail id.
            //string emailPattern = @"^[a-z]{1}[a-z0-9]*([._]?[a-z0-9]+)*\@[a-z0-9]+\.(com|net)(\.[a-z]{2})?$";
            string emailPattern = @"^([a-z0-9A-Z])+([._+-]?[a-z0-9A-Z]+)*[@]{1}[a-z0-9A-Z]+[.]{1}[a-zA-Z]{3}([.]{1}[a-z]{2})?$";
            //satisfies all sample cases of mails.
            //returns true if input matches with email pattern.

            if( Regex.IsMatch(input, emailPattern))
            {
                return true;
            }
            else
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.invalid_email, "invalid email");
            }

        }
        /// <summary>
        /// Mobiles the no.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        /// <exception cref="UserRegistrationCustomException">
        /// UserRegistrationCustomException.ExceptionType.EMPTY_MESSAGE, mobile no can not be empty or null
        /// or
        /// UserRegistrationCustomException.ExceptionType.EMPTY_MESSAGE, mobile no can not be empty or null
        /// </exception>
        public bool MobileNo(string input)
        {
            //pattern for phone no.
            string mobileNoPattern = @"\d{2}\s{1}[6-9]{1}\d{9}";
            //string mobileNoPattern = @"^[1-9]{2}[ ]{1}[0-9]{10}$";
            if(Regex.IsMatch(input, mobileNoPattern))
            {
                  return true ;
            }
            else
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.invalid_phone, "invalid phone");
            }
        }
        /// <summary>
        /// Passwords the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        /// <exception cref="UserRegistrationCustomException">
        /// UserRegistrationCustomException.ExceptionType.EMPTY_MESSAGE, password can not be empty or null
        /// or
        /// UserRegistrationCustomException.ExceptionType.EMPTY_MESSAGE, password can not be empty or null
        /// </exception>
        public bool Password(string input)
        {
            string passwordPattern = @"^(?=.*[A-Z])(?=.*[0-9])(?=.*[^0-9a-zA-Z])(?!.*[^0-9a-zA-Z].*[^0-9a-zA-Z]).{8,}$";
            if(Regex.IsMatch(input, passwordPattern))
            {
                return true ;
            }
            else
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.invalid_password, "invalid password");
            }
        }
    }
}
