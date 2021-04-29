using System;
using PolymorphismDemo.Entities;

namespace PolymorphismDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet pet = new Pet()
            {
                Name = "Jerry"
            };

            Dog dog = new Dog("Sparky", true);
            Cat cat = new Cat()
            {
                Name = "Tom",
                IsLazy = false
            };

            Console.WriteLine(pet.Eat());
            Console.WriteLine(dog.Eat());
            Console.WriteLine(cat.Eat());

            PetStatus(cat, "Cat owner");
            PetStatus(dog, "Dog owner");
            PetStatus(cat);
            PetStatus("Jerry", cat);
        }

        static void PetStatus(Dog dog, string owner)
        {
            Console.WriteLine($"Hi {owner}");
            Console.WriteLine(dog.IsGoodBoi
                ? $"Your dog is a good boi"
                : $"Your dog is not a good boi");
        }

        static void PetStatus(Cat cat, string owner)
        {
            Console.WriteLine($"Hi {owner}");
            Console.WriteLine(cat.IsLazy
                ? $"Your cat is lazy"
                : $"Your cat is not lazy");
        }

        static void PetStatus(Cat cat)
        {
            Console.WriteLine($"This cat does not have an owner");
            Console.WriteLine(cat.IsLazy
                ? $"{cat.Name} is lazy"
                : $"{cat.Name} is not lazy");
        }

        static void PetStatus(string enemy, Cat cat)
        {
            Console.WriteLine($"{cat.Name} enemy is {enemy}");
        }


        //static string PetStatus(Cat cat)
        //{
        //    return $"Hi I am {cat.Name}";
        //}

        //static bool Validate(string username, string password)
        //{
        //    return true;
        //}

        //static bool Validate(string username)
        //{
        //    return true;
        //}

        //static bool Validate(DateTime date)
        //{
        //    return true;
        //}
        static void Print(int age, string name)
        {
            Console.WriteLine($"{name} {age}");
        }

        static void Print(string name, int age)
        {
            Console.WriteLine($"{name} {age}");
        }
    }
}
