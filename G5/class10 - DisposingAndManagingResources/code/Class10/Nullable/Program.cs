using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.Id = 5; // can not hold null as a value
            person.Score = null; // can hold a null value

            person.IsEmplyed = true;
            person.HasPet = null;

            person.Name = null;
        }

        public class Person 
        {
            public int Id { get; set; }
            public int? Score { get; set; }
            public bool IsEmplyed { get; set; }
            public bool? HasPet { get; set; }
            public string Name { get; set; }
        }
    }
}
