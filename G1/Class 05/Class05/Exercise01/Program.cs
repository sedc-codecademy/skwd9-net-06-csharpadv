using System;
using Exercise01.Models;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            PetStore<Dog> dogStore = new PetStore<Dog>("Dog store");
            PetStore<Cat> catStore = new PetStore<Cat>("Cat store");
            PetStore<Fish> fishStore = new PetStore<Fish>("Fish store");
            PetStore<Pet> globalStore = new PetStore<Pet>("Global store");

            Dog d1 = new Dog("Sparky", 5, true, "Meat");
            Dog d2 = new Dog("Bak", 2, false, "Fruit");
            Cat c1 = new Cat("Tom", 2, false, 3);
            Cat c2 = new Cat("Garfield", 6, true, 8);
            Fish f1 = new Fish("Nemo", 1, "red", 10);
            Fish f2 = new Fish("Shark", 12, "grey", 50);

            dogStore.Pets.Add(d1);
            dogStore.Pets.Add(d2);
            catStore.Pets.Add(c1);
            catStore.Pets.Add(c2);
            fishStore.Pets.Add(f1);
            fishStore.Pets.Add(f2);

            globalStore.Pets.Add(d1);
            globalStore.Pets.Add(d2);
            globalStore.Pets.Add(c1);
            globalStore.Pets.Add(c2);
            globalStore.Pets.Add(f1);
            globalStore.Pets.Add(f2);

            Console.WriteLine(dogStore.GetPets());
            Console.WriteLine(catStore.GetPets());
            Console.WriteLine(fishStore.GetPets());
            Console.WriteLine(globalStore.GetPets());

            Console.WriteLine(dogStore.BuyPet("Bak"));
            Console.WriteLine(catStore.BuyPet("Test"));
            Console.WriteLine(globalStore.BuyPet("Tom"));

            Console.WriteLine(dogStore.GetPets());
            Console.WriteLine(catStore.GetPets());
            Console.WriteLine(fishStore.GetPets());
            Console.WriteLine(globalStore.GetPets());
        }
    }
}
