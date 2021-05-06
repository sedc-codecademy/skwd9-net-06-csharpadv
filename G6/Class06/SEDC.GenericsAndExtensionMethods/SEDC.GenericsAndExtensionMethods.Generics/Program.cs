using SEDC.GenericsAndExtensionMethods.Generics.Helpers;
using System;
using System.Collections.Generic;

namespace SEDC.GenericsAndExtensionMethods.Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Not generic methods

            List<string> names = new List<string> { "Martin", "Petre", "Teodora", "Eva" };
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 56, 6 };

            NotGenericListHelper listHelper = new NotGenericListHelper();

            listHelper.GoThroughStrings(names);
            listHelper.GetInfoForStrings(names);

            Console.WriteLine("======================");

            listHelper.GoThroughIntegers(numbers);
            listHelper.GetInfoForIntegers(numbers);

            #endregion


            Console.WriteLine("========================== Using Generics ============================");

            #region Generic Methods

            List<bool> checkList = new List<bool> { true, true, false, false, false };

            GenericListHelper genericListHelper = new GenericListHelper();

            genericListHelper.GoThrough(checkList);
            genericListHelper.GoThrough(names);
            genericListHelper.GoThrough(numbers);

            genericListHelper.GetInfo(checkList);
            genericListHelper.GetInfo(names);
            genericListHelper.GetInfo(numbers);

            #endregion


            Console.WriteLine("========================== Using Generic classes and methods ============================");

            #region Generic classes and methods
            GenericClassListHelper<string> stringHelper = new GenericClassListHelper<string>();
            GenericClassListHelper<int> intHelper = new GenericClassListHelper<int>();

            stringHelper.GoThrough(names);
            stringHelper.GenericProp = "Martin";


            intHelper.GoThrough(numbers);
            intHelper.GenericProp = 2;

            GenericClassListHelper<bool>.GetInfo(checkList);
            GenericClassListHelper<int>.GetInfo(numbers);
            GenericClassListHelper<string>.GetInfo(names);
            #endregion







            Console.ReadLine();
        }
    }
}
