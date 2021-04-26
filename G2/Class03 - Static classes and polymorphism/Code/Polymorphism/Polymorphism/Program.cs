using Polymorphism.Entities;
using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        // Static polymorphism ( Method overloading )
        // Both methods have the same name
        // Their signature is different
        public static void PetStatus(Dog dog, string owner)
        {
            if (dog.Age > 5)
            {
                Console.WriteLine($"{owner} has an old dog");
            }
            else
            {
                Console.WriteLine($"{owner} has a young dog");
            }
        }

        // Signature is different when the order of the properties do not match
        public static void PetStatus(string owner, Dog dog)
        {
            Console.WriteLine($"{owner} has buddy {dog.Name}");
        }

        // Signature is different if the property types do not match or number of properties does not match
        public static void PetStatus(Cat cat)
        {
            string isLazy = cat.IsLazy ? " is lazy " : " is not lazy";
            Console.WriteLine($"Cat {cat.Name} {isLazy}");
        }

        //duplicate signature
        //public static string PetStatus(string owner, Dog dog)
        //{
        //    return owner;
        //}
        static void Main(string[] args)
        {
            Dog sparky = new Dog() { Name = "Sparky", Age = 3 };
            Cat alice = new Cat() { Name = "Alice", IsLazy = true };

            PetStatus("Paul", sparky);
            PetStatus(alice);

            //no problem -> inherited types
            sparky.Eat();
            alice.Eat();

            //thanks to runtime polymorphism the right methods are called
            Pet firstPet = new Dog() { Name = "Sparky", Age = 3 };
            Pet secondPet = new Cat() { Name = "Alice", IsLazy = true };
            firstPet.Eat();
            secondPet.Eat();

            List<Pet> pets = new List<Pet>();
            pets.Add(sparky); //dog
            pets.Add(alice); //cat;
            pets.Add(new Pet() { Name = "Barnie" });

            //thanks to runtime polymorphism the right methods are called
            foreach(Pet pet in pets)
            {
                pet.Eat();
            }


            Console.ReadLine();
        }
    }
}
