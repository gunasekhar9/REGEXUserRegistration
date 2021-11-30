﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEXUserRegistration
{
    public class UserRegistration
    {
        public static string REGEX_FIRST_NAME = "^[A-Z]{1}[a-z]{2,}$";
        public static string REGEX_LAST_NAME = "^[A-Z]{1}[a-z]{2,}$";
        public static string REGEX_EMAIL = "^[a-z]{3,}[_+-.]{0,1}[a-z]{3,}[@][a-z]{2,}[.][a-z]{2}[.][a-z]{2}";
        public static string REGEX_MOBILE = "^[1,9]{2} [6-9]{1}[0-9]{9}";
        public static string REGEX_PASSWORD1 = "^[a-z]{8}";
        public static string REGEX_PASSWORD2 = "^[A-Z]{1}[a-z]{7}$";
        public static string REGEX_PASSWORD3 = "^[A-Z]{1}[a-z]{7}[0-9]{1}$";
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, REGEX_FIRST_NAME);
        }
        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, REGEX_LAST_NAME);
        }
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
        public bool ValidateMobile(string mobile)
        {
            return Regex.IsMatch(mobile, REGEX_MOBILE);
        }
        public bool ValidatePassword1(string password1)
        {
            return Regex.IsMatch(password1, REGEX_PASSWORD1);
        }
        public bool ValidatePassword2(string Password2)
        {
            return Regex.IsMatch(Password2, REGEX_PASSWORD2);
        }
        public bool ValidatePassword3(string password3)
        {
            return Regex.IsMatch(password3, REGEX_PASSWORD3);
        }

    }
}