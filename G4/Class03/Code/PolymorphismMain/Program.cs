using PolymorphismMain.Entities;
using System;

namespace PolymorphismMain
{
    class Program
    {
		#region Static Methods
		// Static polymorphism ( Method overloading )
		// All methods have the same name
		// Their signature is different
		public static void PetStatus(Dog pet, string ownerName)
		{
			Console.WriteLine($"Hey there {ownerName}");
			if (pet.IsGoodBoi) Console.WriteLine("This dog is a good boi :)");
			else Console.WriteLine("This dog is not really a good boi :(");
		}
		// Signature is different when the order of the properties do not match
		public static void PetStatus(string ownerName, Dog pet)
		{
			Console.WriteLine($"Hey there {ownerName}. Happy to see you again!");
			if (pet.IsGoodBoi) Console.WriteLine("This dog is still a good boi :)");
			else Console.WriteLine("This dog is still not really a good boi :(");
		}
		// Sugnature is different if the property types do not match
		public static void PetStatus(Cat pet, string ownerName)
		{
			Console.WriteLine($"Hey there {ownerName}");
			if (pet.IsLazy) Console.WriteLine("This cat is really lazy :(");
			else Console.WriteLine("This cat is cool and not lazy at all :)");
		}
		// Sugnature is different if the number of properties do not match
		public static void PetStatus(Cat pet)
		{
			Console.WriteLine($"Hey, a cat with no owner.");
			if (pet.IsLazy) Console.WriteLine("This cat is really lazy :(");
			else Console.WriteLine("This cat is cool and not lazy at all :)");
		}

		#endregion
		static void Main(string[] args)
        {
            #region Dynamic Polymorphism Example
            // Dynamic Polymorphism (class method overriding) - in runtime
            Dog dog = new Dog() { Name = "Sparky", IsGoodBoi = true };
            Cat cat = new Cat() { Name = "Mitsi", IsLazy = false };

            // Both call the same methods (different types), same methods, but different implementation
            dog.Eat();
            cat.Eat();
			#endregion

			#region Static Polymorphism Example
			// All methods have the same name and the implementation is different
			Console.WriteLine("-----------------------");
			PetStatus(dog, "Pero");
            Console.WriteLine("-----------------------");
			PetStatus("Blazo", dog);
			Console.WriteLine("-----------------------");
			PetStatus(cat);
			Console.WriteLine("-----------------------");
			PetStatus(cat, "Kiki");

			#endregion

			Console.ReadLine();
        }
    }
}
