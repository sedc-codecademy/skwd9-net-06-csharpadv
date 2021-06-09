using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.TryBeingFit.Services.Helpers
{
    public static class ValidationHelper
    {
        public static string ValidateName(string str, int length)
        {
            if (str.Length < length) return null;
            return str;
        }

        public static string ValidatePassword(string password)
        {
             return (password.Length < 6 || !password.Any(char.IsDigit)) ? null : password;

            //Second way
            //if (password.Length < 6) return null;
            //bool isNum = password.Any(char.IsDigit);
            

            //Third way
            //bool isNum = false;
            //foreach (char item in password)
            //{
            //    isNum = int.TryParse(item.ToString(), out int num);
            //}

            //if (!isNum) return null;
            //return password;
        }

        public static int ValidateNumber(string number, int range)
        {
            bool isNumber = int.TryParse(number, out int num);
            if (!isNumber) 
                return -1;

            if (num <= 0 || num > range) 
                return -1;

            return num;
        }
    }
}
