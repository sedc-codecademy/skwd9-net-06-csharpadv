using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    class Program
    {
        public static List<string> CountryCodes = new List<string> {"389", "386", "388"};
        public static List<string> OperatorCodes = new List<string> {"70", "71", "72", "75", "78"};
        static void Main(string[] args)
        {
            bool isValid = ValidPhoneNumber("+38870123400");
        }

        //+38970123456
        //public static bool ValidPhoneNumber(string phone)
        //{
        //    //if (phone.Length == 12)
        //    //{
        //    //    if (phone.StartsWith("+"))
        //    //    {
        //    //        string countryCode = phone.Substring(1, 3);
        //    //        if (CountryCodes.Contains(countryCode)) return true;
        //    //    }
        //    //}

        //    //return false;

        //    //if (phone.Length == 12 && 
        //    //    phone.StartsWith("+") && 
        //    //    CountryCodes.Contains(phone.Substring(1, 3)))
        //    //{
        //    //    return true;
        //    //}

        //    //return false;

        //    //return phone.Length == 12 && 
        //    //       phone.StartsWith("+") && 
        //    //       CountryCodes.Contains(phone.Substring(1, 3));

        //    //Invert IF
        //    if (phone.Length != 12) return false;
        //    if (!phone.StartsWith("+")) return false;

        //    string countryCode = phone.Substring(1, 3);
        //    if (!CountryCodes.Contains(countryCode)) return false;

        //    string operatorCode = phone.Substring(4, 2);
        //    if (!OperatorCodes.Contains(operatorCode)) return false;

        //    //char[] phoneDigits = phone.Substring(6, 6).ToCharArray();

        //    //foreach (char phoneDigit in phoneDigits)
        //    //{
        //    //    if (!char.IsDigit(phoneDigit))
        //    //        return false;
        //    //}

        //    //string[] phoneDigits1 = phone.Substring(6, 6).Split("");

        //    //foreach (string phoneDigit in phoneDigits1)
        //    //{
        //    //    if (!int.TryParse(phoneDigit, out int digit))
        //    //        return false;
        //    //}

        //    List<char> phoneDigits = phone.Substring(6, 6).ToCharArray().ToList();

        //    //if (!phoneDigits.All(x => char.IsDigit(x)))
        //    //    return false;

        //    //if (!phoneDigits.All(char.IsDigit))
        //    //    return false;

        //    //if (phoneDigits.Any(x => !char.IsDigit(x)))
        //    //    return false;

        //    //return true;

        //    return phoneDigits.All(char.IsDigit);
        //}

        static bool ValidPhoneNumber(string phone)
        {
            Regex regex = new Regex(@"^[+](389|386|388)(70|71|72|75|78)\d{6}$");
            
            return regex.IsMatch(phone);
        }
    }
}
