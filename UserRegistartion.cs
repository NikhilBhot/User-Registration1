using System;
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
        public string ValidFirstName(string input) => Regex.IsMatch(input, FIRST_NAME_REGEX) ? "true" : "flase";
        public void ValidateFName(string input)
        {

            bool res=Regex.IsMatch(input, FIRST_NAME_REGEX);
            if (res==true)
            {

                Console.WriteLine("UserName Is Valid");
            }
            else
            {
                Console.WriteLine("User Name Is Invalid");
            }

           
        }

    }
}
