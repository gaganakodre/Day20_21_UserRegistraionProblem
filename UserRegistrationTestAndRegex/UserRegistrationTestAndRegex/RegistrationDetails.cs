﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationTestAndRegex
{
    public class UserRegistrationDetails
    {
        //UC1
        public static string Regex_FirstName = "^[A-Z][a-z]{2,}$";
        
        public bool ValidateFirstName(string firstName)
        {
            try
            {
                if (firstName.Equals(string.Empty))
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.Empty_Message, "Name should not be empty.");
                }
                else if (Regex.IsMatch(firstName, Regex_FirstName))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.NULL_Message, "Name should not be null.");
            }
        }

    }
}
