using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SEDC.CSharpAdv.Class14.SB
{
    class Program
    {
        static void Main(string[] args)
        {
            // MailExample();


            // this will write in the debug console in the ouput window -> output window can be opened with view->output
            // Debug.WriteLine("We are writing in the debug console");

            var data = Enumerable.Repeat("abcdefg", 80000); // increase data count on your responsability

            Console.WriteLine("We have " + data.Count() + " string to concat");

            Console.WriteLine("=====Using concatenation=====");
            Stopwatch stopwatch = Stopwatch.StartNew();

            var result = string.Empty;
            foreach (var word in data)
            {
                result += word;
            }

            stopwatch.Stop();
            Console.WriteLine("The length of the string is " + result.Length);
            Console.WriteLine("Duration: {0} ms", stopwatch.ElapsedMilliseconds);


            Console.WriteLine("=====USING STRING BUILDER=====");
            stopwatch = Stopwatch.StartNew();

            var result2 = new StringBuilder(string.Empty);
            foreach (var word in data)
            {
                result2.Append(word);
            }

            stopwatch.Stop();
            string stringResult = result2.ToString();
            Console.WriteLine("The length of the string is " + stringResult.Length);
            Console.WriteLine("Duration: {0} ms", stopwatch.ElapsedMilliseconds);

            Console.ReadLine();
        }

        public static void MailExample()
        {
            var mailService = new MailService();
            mailService.SendMail("trajanstevkovski@gmail.com", "trajan", "Trajan Stevkovski", "SEDC");
        }
    }
}
