using SEDC.CSharpAdv.Class03.Polymorphisam.Entites;
using System;

namespace SEDC.CSharpAdv.Class03.Polymorphisam
{
    class Program
    {
        static void Main(string[] args)
        {
            // dynamic polymorphism
            Dog dog = new Dog() { Name = "Sparky", IsGoodBoi = true };
            Cat cat = new Cat() { Name = "Meow", IsLazy = true };

            //dog.Eat();
            //cat.Eat();

            Pet meow = new Cat() { Name = "Meow 1", IsLazy = false };
            meow.Eat();

            PetStatus(dog, "Trajan");
            PetStatus("Bob", dog);
            PetStatus(cat, "Nikola");
            PetStatus("Jill", cat);
            PetStatus(dog, cat, "Wayne", true, 15);

            Example ex = new Example();

            ex.TestMethod();

            Console.ReadLine();
        }

        public static void PetStatus(Dog dog, string ownerName)
        {
            Console.WriteLine($"Hey there {ownerName}");
            if(dog.IsGoodBoi)
            {
                Console.WriteLine("The dog is a good boi");
            }
            else
            {
                Console.WriteLine("The dog is not realy good");
            }
        }

        public static void PetStatus(string ownerName, Dog dog)
        {
            Console.WriteLine($"Hey there {ownerName}, Hey there again!");
            if (dog.IsGoodBoi)
            {
                Console.WriteLine("The dog is a good boi");
            }
            else
            {
                Console.WriteLine("The dog is not realy good");
            }
        }

        public static void PetStatus(Cat cat, string ownerName)
        {
            Console.WriteLine($"Hey there {ownerName}");
            if (cat.IsLazy)
            {
                Console.WriteLine("The cat is lazy");
            }
            else
            {
                Console.WriteLine("The cat is not lazr");
            }
        }

        public static void PetStatus(string ownerName, Cat cat)
        {
            Console.WriteLine($"Hey there {ownerName}, Hey there with cat param.");
            if (cat.IsLazy)
            {
                Console.WriteLine("The cat is lazy");
            }
            else
            {
                Console.WriteLine("The cat is not lazr");
            }
        }

        public static void PetStatus(Dog dog, Cat cat , string ownerName, bool isSomething, int age)
        {
            Console.WriteLine("To much params to deal with");
        }

    }
}
