using SEDC.CSharpAdv.VideoRental.Data.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.VideoRental.Services.Helpers
{
    public static class InputParser
    {
        private static List<string> _validConfirmInputs = new List<string> { "Y", "y", "Yes", "1", "True" };
        private static List<string> _validDeclineInputs = new List<string> { "N", "n", "No", "0", "False" };

        public static Genre ToGenre()
        {
            while (true)
            {
                int counter = 0;
                foreach (var item in Enum.GetNames(typeof(Genre)))
                {
                    Console.WriteLine($"{counter + 1}. {item}");
                    counter++;
                }
                var genreSelection = ToInteger(1, Enum.GetNames(typeof(Genre)).Length);
                var isValid = Enum.TryParse(typeof(Genre), (genreSelection - 1).ToString(), out var genre);

                if(isValid)
                {
                    return (Genre)genre;
                }

                Console.WriteLine("Please enter valid input");
            }
        }

        public static DateTime ToDateTime()
        {
            while (true)
            {
                Console.Write("Enter year: ");
                int year = ToInteger(1900, DateTime.Now.Year - 18);
                Console.Write("\nEnter month: ");
                int month = ToInteger(1, 12);
                Console.Write("\nEnter day: ");
                int day = ToInteger(1, DateTime.DaysInMonth(year, month));
                try
                {
                    DateTime dob = new DateTime(year, month, day);
                    return dob;
                }
                catch (Exception)
                {
                    Console.WriteLine("Not valid input");
                }
            }
        }

        public static bool ToConfirm()
        {
            while (true)
            {
                string value = Console.ReadLine();

                if (_validConfirmInputs.Contains(value))
                {
                    return true;
                }
                else if (_validDeclineInputs.Contains(value))
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter valid input");
                    Console.WriteLine($"Valid inputs {string.Join(", ", _validConfirmInputs)} and {string.Join(", ", _validDeclineInputs)}");
                }
            }
        }

        public static int ToInteger(string input, int min, int max)
        {
            return ValidateInput(input, min, max);
        }

        public static int ToInteger(int min, int max)
        {
            while (true)
            {
                int parsedNumber = ValidateInput(Console.ReadLine(), min, max);
                if(parsedNumber != 0)
                {
                    return parsedNumber;
                }
            }
        }

        private static int ValidateInput(string input, int min, int max)
        {
            int parsedNumber = 0;
            try
            {
                parsedNumber = int.Parse(input);
                if(!(parsedNumber >= min && parsedNumber <= max))
                {
                    throw new Exception($"Please select from the given range from {min} to {max}");
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter argument");
            }
            catch (FormatException)
            {
                Console.WriteLine("Not valid input");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number is to large or to low");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return parsedNumber;
        }

    }
}
// Y, y, yes, Yes, 1, True
// N, n, no, No, 0, False