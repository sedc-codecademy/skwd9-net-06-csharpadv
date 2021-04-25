using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1990; i < 2021; i++)
            {
                var month = (i % 12) + 1; //to get a month from 1 to 12
                var day = (DateTime.UtcNow.Millisecond % (DateTime.DaysInMonth(i, month))) + 1; //to get the day in the correct month
                var date = new DateTime(i, month, day);

                var result = CheckIfDateIsNonWorkingDay(date);
                var working = result ? "non working" : "working";
                Console.WriteLine($"Date: {date.ToShortDateString()} is {working} day");
            }
            Console.ReadLine();
        }

        private static bool CheckIfDateIsNonWorkingDay(DateTime date)
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                return true;
            }

            if ((date.Month == 1 && date.Day == 1) || (date.Month == 1 && date.Day == 7))
            {
                return true;
            }
            else if (date.Month == 4 && date.Day == 20)
            {
                return true;
            }
            else if (date.Month == 5 && (date.Day == 1 || date.Day == 25))
            {
                return true;
            }
            else if (date.Month == 8 && date.Day == 3)
            {
                return true;
            }
            else if (date.Month == 9 && date.Day == 8)
            {
                return true;
            }
            else if (date.Month == 10 && (date.Day == 12 || date.Day == 23))
            {
                return true;
            }
            else if (date.Month == 12 && date.Day == 8)
            {
                return true;
            }

            return false;
        }
    }
}
