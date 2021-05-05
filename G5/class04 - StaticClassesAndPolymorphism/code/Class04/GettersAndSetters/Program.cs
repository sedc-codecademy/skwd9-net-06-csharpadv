using GettersAndSetters.Entites;
using System;

namespace GettersAndSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Person viktor = new Person()
            {
                Age = 31
            };

            viktor.Age = 35;

            Console.WriteLine(viktor.Age);

            viktor.Age = 5;

            Console.WriteLine(viktor.Age);

            //viktor.SetName("Viktor");

            //Console.WriteLine(viktor.GetName());

            Console.ReadLine();
        }
    }
}
