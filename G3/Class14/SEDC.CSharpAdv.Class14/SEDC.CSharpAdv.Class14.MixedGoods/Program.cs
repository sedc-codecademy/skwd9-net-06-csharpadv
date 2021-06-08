using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.CSharpAdv.Class14.MixedGoods
{
    class Program
    {
        static void Main(string[] args)
        {
            //CoalescingOperator();
            //CoalescingOperator(3);

            var input = Console.ReadLine();

            bool isValidInput = int.TryParse(input, out int result);

            if (!isValidInput)
            {
                throw new Exception();
            }

            Console.WriteLine(result);


            Console.ReadLine();
        }

        public static void CoalescingOperator(int? number = null)
        {
            int realNumber = 0;

            //if(number != null)
            //{
            //    realNumber = number.Value;
            //}
            //else
            //{
            //    realNumber = 10;
            //}

            //realNumber = number.HasValue ? number.Value : 10;

            realNumber = number ?? 10;

            Console.WriteLine(realNumber);
        }

        public static bool CommentedCode()
        {
            /*
             * 
             * This code might have value later in this project
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * LOTS OF NOT NEEDED CODE
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             */

            // this check is needed for {something}
            if(false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidateEmailDONT()
        {
            var email = Console.ReadLine();

            if (email.Contains("@"))
            {
                return true;
            }
            return false;
        }

        public static bool ValidateEmailDO(string email)
        {
            if (email.Contains("@"))
            {
                return true;
            }
            return false;
        }

        public IEnumerable<string> SelectUsersDONT(List<string> list)
        {
            return list.Select(x => x.ToUpper());
        }

        public IEnumerable<string> FilterAndSelectUsersThatStartWithA(List<string> list)
        {
            return list.Where(x => x.StartsWith("a")).Select(x => x.ToUpper());
        }
    }
}
