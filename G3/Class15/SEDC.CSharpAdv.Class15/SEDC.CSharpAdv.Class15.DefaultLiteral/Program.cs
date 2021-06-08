using System;
using System.Collections.Generic;

namespace SEDC.CSharpAdv.Class15.DefaultLiteral
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = 0;

            int integerValue = default;
            bool booleanValue = default;
            decimal decimalValue = default;
            string stringValue = default;
            List<string> listOfStringValue = default;

            Console.WriteLine($"{integerValue} - Type: {integerValue.GetType().Name}");
            Console.WriteLine($"{booleanValue} - Type: {booleanValue.GetType().Name}");
            Console.WriteLine($"{decimalValue} - Type: {decimalValue.GetType().Name}");
            Console.WriteLine($"{stringValue} - IsNull: {stringValue == null}");
            Console.WriteLine($"{listOfStringValue} - IsNull: {listOfStringValue == null}");


            List<string> newListWithValues = CreateList<string>(6, "Bob");
            List<int> newListWithIntsDefault = CreateList<int>(10);
            List<bool> newListWithBooleansDefault = CreateList<bool>(5);
            List<decimal> newListDecimalWithLengthZero = CreateList<decimal>(0);

            Console.WriteLine($"Type of list = {newListWithValues.GetType().Name} of {newListWithValues[0].GetType().Name} and the items in it are {newListWithValues[0]}");
            Console.WriteLine($"Type of list = {newListWithIntsDefault.GetType().Name} of {newListWithIntsDefault[0].GetType().Name} and the items in it are {newListWithIntsDefault[0]}");
            Console.WriteLine($"Type of list = {newListWithBooleansDefault.GetType().Name} of {newListWithBooleansDefault[0].GetType().Name} and the items in it are {newListWithBooleansDefault[0]}");
            Console.WriteLine($"IsNull {newListDecimalWithLengthZero == null}");

            Console.ReadLine();
        }

        public static List<T> CreateList<T>(int length, T initialValue = default)
        {
            if(length <= 0)
            {
                return default;
            }
            var list = new List<T>();
            for(int i = 0; i < length; i++)
            {
                list.Add(initialValue);
            }
            return list;
        }
    }
}
