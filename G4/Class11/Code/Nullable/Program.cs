using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pero = new Person();
            Console.WriteLine(pero.Id); // 0 by default
            //pero.Id = null; // cannot put null as value
            Console.WriteLine(pero.Score == null ? "I am null" : $"{pero.Score}");
            pero.Score = null;

            Console.WriteLine(pero.IsEmployed); // false by default
            Console.WriteLine(pero.HasPet == null ? "I am null" : $"{pero.HasPet}");

            pero.Name = "Pero";
            pero.Name = null; // String is nullable by default

            pero = null; // Every object is nullable and default value is null
            Console.ReadLine();
        }
    }
}
