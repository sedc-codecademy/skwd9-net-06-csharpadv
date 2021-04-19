using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DateTime> holidays = new List<DateTime>()
            {
                new DateTime(DateTime.Now.Year, 1, 1),
                new DateTime(DateTime.Now.Year, 1, 7),
                new DateTime(DateTime.Now.Year, 4, 20),
                new DateTime(DateTime.Now.Year, 4, 30),
                new DateTime(DateTime.Now.Year, 5, 1),
                new DateTime(DateTime.Now.Year, 5, 3),
                new DateTime(DateTime.Now.Year, 5, 25),
                new DateTime(DateTime.Now.Year, 8, 2),
                new DateTime(DateTime.Now.Year, 9, 8),
                new DateTime(DateTime.Now.Year, 10, 12),
                new DateTime(DateTime.Now.Year, 10, 23),
                new DateTime(DateTime.Now.Year, 12, 10)
            };

            while (true)
            {
                try
                {
                    //day.month.year
                    //Console.WriteLine("Please enter a date for check in format day.month.year");
                    Console.WriteLine("Please enter a date for check in format month/day/year");
                    string inputDate = Console.ReadLine();

                    //bool successfulParse = DateTime.TryParseExact(inputDate, new string[]
                    //{
                    //    "MM/dd/yyyy",
                    //    "M/d/yyyy",
                    //    "M/dd/yyyy",
                    //    "MM/d/yyyy",
                    //}, new CultureInfo("en-US"), DateTimeStyles.None, out DateTime selectDateParse);

                    //bool successfulParse = DateTime.TryParse(inputDate, out DateTime selectDate);
                    //if (!successfulParse)
                    //{
                    //    Console.WriteLine("Wrong input for date");
                    //    continue;
                    //}

                    //if (selectDate.DayOfWeek == DayOfWeek.Saturday || selectDate.DayOfWeek == DayOfWeek.Sunday)
                    //{
                    //    Console.WriteLine("Not working day");
                    //    continue;
                    //}

                    //if (holidays.Any(x => x.Day == selectDate.Day && x.Month == selectDate.Month))
                    //{
                    //    Console.WriteLine("Not working day");
                    //    continue;
                    //}

                    //Console.WriteLine("Working day");

                    string[] date = inputDate.Split("/");

                    if (date.Length != 3)
                    {
                        throw new Exception("Wrong input for date");
                    }

                    int[] dateSegments = new int[3];

                    for (int i = 0; i < date.Length; i++)
                    {
                        bool successParse = int.TryParse(date[i], out int segment);

                        if (!successParse)
                        {
                            throw new Exception("Wrong input for date");
                        }

                        dateSegments[i] = segment;
                    }

                    DateTime selectDate = new DateTime(dateSegments[2], dateSegments[0], dateSegments[1]);

                    if (selectDate.DayOfWeek == DayOfWeek.Saturday || selectDate.DayOfWeek == DayOfWeek.Sunday)
                    {
                        Console.WriteLine("Not working day");
                        continue;
                    }

                    if (holidays.Any(x => x.Day == selectDate.Day && x.Month == selectDate.Month))
                    {
                        Console.WriteLine("Not working day");
                        continue;
                    }

                    Console.WriteLine("Working day");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
