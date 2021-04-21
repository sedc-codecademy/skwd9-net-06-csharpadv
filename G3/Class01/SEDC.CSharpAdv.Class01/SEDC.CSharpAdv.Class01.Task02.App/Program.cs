using SEDC.CSharpAdv.Class01.Task02.Logic.Services;
using System;

namespace SEDC.CSharpAdv.Class01.Task02.App
{
    class Program
    {
        static void Main(string[] args)
        {
            FreeDayService freeDayService = new FreeDayService();

            for (int i = 1990; i < 2021; i++)
            {
                int month = (i % 12) + 1;
                int day = (int)(DateTime.Now.Ticks % (DateTime.DaysInMonth(i, month))) + 1;
                DateTime date = new DateTime(i, month, day);

                bool result = freeDayService.CheckIfDateIsNonWorkingDay(date);
                string working = result ? "non working" : "working";
                Console.WriteLine($"Date: {date.ToShortDateString()} is {working} day");
            }

            Console.WriteLine("---------------------- SECOND WAY --------------------------");

            for (int i = 1990; i < 2021; i++)
            {
                int month = (i % 12) + 1;
                int day = (int)(DateTime.Now.Ticks % (DateTime.DaysInMonth(i, month))) + 1;
                DateTime date = new DateTime(i, month, day);

                bool result = freeDayService.CheckIfDateIsNonWorkingDay1(date);
                string working = result ? "non working" : "working";
                Console.WriteLine($"Date: {date.ToShortDateString()} is {working} day");
            }

            Console.WriteLine("---------------------- THIRD WAY --------------------------");

            for (int i = 1990; i < 2021; i++)
            {
                int month = (i % 12) + 1;
                int day = (int)(DateTime.Now.Ticks % (DateTime.DaysInMonth(i, month))) + 1;
                DateTime date = new DateTime(i, month, day);

                bool result = freeDayService.CheckIfDateIsNonWorkingDay2(date);
                string working = result ? "non working" : "working";
                Console.WriteLine($"Date: {date.ToShortDateString()} is {working} day");
            }

            Console.ReadLine();
        }
    }
}
