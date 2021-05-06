using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.CSharpAdv.Class06.Anonymous
{
    class Program
    {
        public delegate void PrintString(string str);

        static void Main(string[] args)
        {
            #region Old way using delagate
            // Old way of creating anonymuou methods
            //var example = new Example();

            //PrintString fnc = example.PrintStringInConsole;
            //fnc += example.PrintStringPlusOne;

            //for(int i = 0; i < 100; i++)
            //{
            //    fnc(i.ToString());
            //}
            #endregion

            #region Action

            Action welcomeMsg = () => Console.WriteLine("Welcome");
            // welcomeMsg();

            Action<string> hello = (str) => Console.WriteLine("Hello " + str);
            //hello("Trajan");

            Action<string, ConsoleColor> printMsgWithColor = (msg, color) =>
            {
                Console.ForegroundColor = color;
                Console.WriteLine(msg);
                Console.ResetColor();
            };
            //printMsgWithColor("Hello SEDC", ConsoleColor.Green);

            Action<string, int, string, double, string, int, ConsoleColor> callWith7Params =
                (str, num, str1, dnum, str2, num1, color) =>
                {
                    Console.ForegroundColor = color;
                    Console.WriteLine(str + num.ToString() + str1 + dnum.ToString() + str2 + num1);
                    Console.ResetColor();
                };
            //callWith7Params("str", 1, "str2", 2.2, "str3", 2, ConsoleColor.DarkMagenta);
            #endregion

            #region Func

            Func<string> func = () => "Func has a return type of type string";
            string res = func();
            //Console.WriteLine(res);

            Func<int, int, int> sumInts = (num, num1) => num + num1;
            int result = sumInts(3, 4);
            //Console.WriteLine(result);

            List<int> listOfNums = new List<int> { 1, 2, 3, 4, 5 };
            Func<bool> isListEmpty = () => listOfNums.Count == 0;
            //Console.WriteLine(isListEmpty());

            Func<int, int, bool> checkLarger = (num, num1) =>
              {
                  if (num > num1)
                  {
                      return true;
                  }
                  return false;
              };
            //Console.WriteLine(checkLarger(10,2));
            //Console.WriteLine(checkLarger(2,10));

            Func<int, string, double, string, long, short, string> funcWith6Params =
                (num, str, dnum, str2, lnum, snum) =>
                {
                    var result = num + dnum + lnum + snum;
                    return str + str2 + " Result: " + result;
                };
            var res1 = funcWith6Params(1, "func", 2.2, " is awesome", 123123, 132);
            //Console.WriteLine(res1);

            #endregion

            #region Like a delagate

            Action<string> fnc1 = str =>
            {
                string reversed = string.Join("", str.Reverse());
                Console.WriteLine(str.ToLower() == reversed.ToLower() ? "Is palindrom" : "Not a palindrome");
            };

            Action<string> fnc2 = str =>
            {
                Console.WriteLine($"Has: {str.Split(" ").Length} words");
            };

            Action<string> fnc3 = str =>
            {
                string reversed = string.Join("", str.Reverse());
                Console.WriteLine(reversed);
            };

            fnc1 += fnc2;
            fnc1 += fnc3;

            //fnc1("Ana e radar");
            //fnc1("Madam");
            #endregion

            List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            var evenNumbers = ints.Where(x => x % 2 == 0).ToList();

            Func<int, bool> getOddNumbers = num => num % 2 != 0;
            var oddNumbers = ints.Where(getOddNumbers).ToList();

            Func<int, Num> convertToNum = num => new Num { Number = num };

            var nums = ints.Select(convertToNum).ToList();

            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item.GetType());
            //    Console.WriteLine(item.Number);
            //}
            var ex1 = new Example();

            Func<int, int, int> sum = (num, num1) => num + num1;
            var nums1 = ex1.AddNToElementInList(ints, sum);

            var nums2 = ex1.AddNToElementInList(ints, (x, y) => y - x);

            //for (int i = 0; i < nums1.Count; i++)
            //{
            //    Console.WriteLine(nums1[i] + " Sum");
            //    Console.WriteLine(nums2[i] + " Devide");
            //}

            Console.ReadLine();
        }

        public class Example
        {
            public void PrintStringInConsole(string str)
            {
                Console.WriteLine(str);
            }

            public void PrintStringPlusOne(string str)
            {
                Console.WriteLine(str + " PlusOne");
            }

            public List<int> AddNToElementInList(List<int> list, Func<int , int, int> func)
            {
                var listOfInts = new List<int>();
                foreach (var num in list)
                {
                    int result = func(num, 10);
                    listOfInts.Add(result);
                }
                return listOfInts;
            }
        }

        public class Num
        {
            public int Number { get; set; }
        }
    }
}
