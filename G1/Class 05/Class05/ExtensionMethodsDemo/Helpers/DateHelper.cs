using System;

namespace ExtensionMethodsDemo.Helpers
{
    public static class DateHelper
    {
        public static string CalculateYears(this DateTime time, string name)
        {
            int years = (DateTime.Now - time).Days / 365;
            return $"{name} has: {years} years";
        }

        public static string ReplaceWithEmpty(this string text, char oldChar)
        {
            return text.Replace(oldChar, ' ');
        }
    }
}
