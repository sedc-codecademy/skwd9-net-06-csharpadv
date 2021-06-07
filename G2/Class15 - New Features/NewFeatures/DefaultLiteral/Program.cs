using System;
using System.Collections.Generic;

namespace DefaultLiteral
{
    class Program
    {
        static void Main(string[] args)
        {
            int integerValue = default; //0
            bool booleanValue = default; //false
            double doubleValue = default; //0
            string stringValue = default; //null

            bool? nullableBoolean = default; //null
            List<string> stringsList = default; //null
            char character = default;


            string stringType = stringValue == null ? "string" : stringValue.GetType().Name;

            Console.WriteLine($"Value: {integerValue} - Type: {integerValue.GetType()} - {integerValue.GetType().Name}");
            Console.WriteLine($"Value: {booleanValue} - Type: {booleanValue.GetType()} - {booleanValue.GetType().Name}");
            Console.WriteLine($"Value: {doubleValue} - Type: {doubleValue.GetType()} - {doubleValue.GetType().Name}");
            Console.WriteLine($"Value: {character} - Type: {character.GetType()} - {character.GetType().Name}");
            Console.WriteLine($"Value: {stringValue} - Type: {stringType}");
            Console.WriteLine($"Value: {nullableBoolean} - IsNull: {nullableBoolean == null}");
            Console.WriteLine($"Value: {stringsList} - IsNull: {stringsList == null}");

            List<string> newListOfStrings = CreateList<string>(5, "Hi");
            List<double> newListOfDoubles = CreateList<double>(7);
            List<int> emptyIntList = CreateList<int>(0);

            Console.ReadLine();
        }

        public static List<T> CreateList<T>(int numOfItems, T initialValue = default)
        {
            if(numOfItems <= 0)
            {
                return default; //null -> null is default for List<T>
            }
            List<T> list = new List<T>();
            for(int i=0; i< numOfItems; i++)
            {
                list.Add(initialValue);
            }
            return list;
        }
    }
}
