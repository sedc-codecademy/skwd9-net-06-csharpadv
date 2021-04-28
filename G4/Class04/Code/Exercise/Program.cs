using Exercise.Entities;
using System;

namespace Exercise
{
    class Program
    {
        public static PetStore<Dog> DogStore = new PetStore<Dog>();
        public static PetStore<Cat> CatStore = new PetStore<Cat>();
        public static PetStore<Fish> FishStore = new PetStore<Fish>();
        static void Main(string[] args)
        {
            DogStore.Insert(new Dog() { Name = "Sparky", Age = 2, Type = "labrador", GoodBoi = true, FavoriteFood = "Chicken" });
            DogStore.Insert(new Dog() { Name = "Sharko", Age = 12, Type = "dzukela", GoodBoi = false, FavoriteFood = "Papuchi" });
            DogStore.PrintPets();
            Console.WriteLine("Buying Trpe");
            DogStore.BuyPet("Trpe");
            Console.WriteLine("Buying Sparky");
            DogStore.BuyPet("Sparky");
            DogStore.PrintPets();

            Console.WriteLine("------------------------------");
            CatStore.Insert(new Cat() { Name = "Mitsi", Age = 2, Type = "domestic", Lazy = true, LivesLeft = 6 });
            CatStore.Insert(new Cat() { Name = "Cleo", Age = 12, Type = "dzukela", Lazy = false, LivesLeft = 1 });
            CatStore.PrintPets();
            Console.WriteLine("Buying aaa");
            CatStore.BuyPet("Aaa");
            Console.WriteLine("Buying Cleo");
            CatStore.BuyPet("Cleo");
            CatStore.PrintPets();

            Console.WriteLine("------------------------------");
            FishStore.Insert(new Fish() { Name = "Fishy", Age = 2, Type = "clown fish", Color = "Orange", Size = "xs" });
            FishStore.Insert(new Fish() { Name = "Bobby", Age = 12, Type = "shark", Color = "White", Size = "xxl" });
            FishStore.PrintPets();
            Console.WriteLine("Buying fishhhh");
            FishStore.BuyPet("Fish");
            Console.WriteLine("Buying Bobby");
            FishStore.BuyPet("Bobby");
            FishStore.PrintPets();

            Console.ReadLine();
        }
    }
}
