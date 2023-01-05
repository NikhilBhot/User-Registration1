﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration1
{
    public class UserRegistartion
    {
        public const string FIRST_NAME_REGEX = "^[A-Z][A-za-z]{2,}$";
        public const string LAST_NAME_REGEX = "^[A-Z][A-za-z]{2,}$";
        public const string EMAIL = "^[A-Za-z0-9]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}$";
        public const string MOBILE_NUMBER = "^(91)[' ']?[7-9]{1}[0-9]{9}$";
        public string ValidFirstName(string input) => Regex.IsMatch(input, FIRST_NAME_REGEX) ? "true" : "flase";
        public void ValidateFName(string input)
        {
            bool res=Regex.IsMatch(input, FIRST_NAME_REGEX);
            if (res==true)
            {
                Console.WriteLine("User First Name Is Valid");
            }
            else
            {
                Console.WriteLine("User First Name Is Invalid");
            }
        }

        public string ValidLastName(string input) => Regex.IsMatch(input, LAST_NAME_REGEX) ? "true" : "flase";
        public void ValidateLName(string input)
        {
            bool res = Regex.IsMatch(input, LAST_NAME_REGEX);
            if (res == true)
            {
                Console.WriteLine("User Last Name Is Valid");
            }
            else
            {
                Console.WriteLine("User Last Name Is Invalid");
            }
        }

       
        public string ValidEmail(string input) => Regex.IsMatch(input, EMAIL) ? "true" : "flase";
        public void ValidateEmail(string input)
        {
            bool res = Regex.IsMatch(input, EMAIL);
            if (res == true)
            {
                Console.WriteLine("User Email Is Valid");
            }
            else
            {
                Console.WriteLine("User Email Is Invalid");
            }

        }

        public string ValidMobileNumber(string input) => Regex.IsMatch(input, MOBILE_NUMBER) ? "true" : "flase";
        public void ValidateMobileNo(string input)
        {
            bool res = Regex.IsMatch(input, EMAIL);
            if (res == true)
            {
                Console.WriteLine("User Mobile No Is Valid");
            }
            else
            {
                Console.WriteLine("User Mobile No Is Invalid");
            }

        }
    }
}
