using System;

namespace SEDC.CSharpAdv.Class10.Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            Console.WriteLine(person.Id); // int by default is 0
            Console.WriteLine(person.Score); // null by default

            // person.Id = null; // we can't put null in an int
            person.Score = null; // if int is declared nullable we can set it to null

            Console.WriteLine(person.IsEmployed); // bool default is false
            Console.WriteLine(person.HasPet); // null by default

            // person.IsEmployed = null; // bool default is false and cannot be set to null
            person.HasPet = null; // if bool is declared nullable can be set to null

            Console.WriteLine(person.Name);

            person.Name = null; // string is nullable by default
            person.Name = "Trajan";

            person = null;

            Console.ReadLine();
        }

        public class Person
        {
            public int Id { get; set; }
            public Nullable<int> Score { get; set; } // old way
            public bool IsEmployed { get; set; }
            public bool? HasPet { get; set; } // new way
            public string Name { get; set; }
        }
    }
}
