using SpecialClasses.Partial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nested Classes
            Human bob = new Human() { FirstName = "Bob", LastName = "Bobsky" };
            bob.Talk("Hello!");
            Human.Address adresa = new Human.Address() { Number = 5, Street = "Gjurgjevska" };
            adresa.MoveIn(bob);
            adresa.EnterHouse(1234);
            Company kompanija = new Company();
            Company.Address adresa2 = new Company.Address();
            // adresa.PassCode // We can't access PassCode from here, only from inside Address
            Console.ReadLine();

            //Static Classes
            List<string> words = new List<string>() { "Hey", "Hi", "Ho", "Heeeeek" };
            List<int> nums = new List<int>() { 2, 4, -5, 222 };
            // Using the static class imidietly, without creating instance
            CollectionHelper.CycleThroughStrings(words);
            CollectionHelper.CycleThroughIntegers(nums);
            // CollectionHelper helper = new CollectionHelper(); // THIS WILL NOT WORK 
            Console.WriteLine(CollectionHelper.NumberOfUses);
            Console.ReadLine();

            // Partial Classes
            
            // We add stuff the same as we do with normal classes, even tho it is partial
            User jill = new User() { BonusCardNumber = 34234, Password = "SuperSte", Username = "jill23" };
            jill.ProductToCart("Potato");
            Console.ReadLine();
            Human greg = new Human();
            // greg.AddedToCart(); // we cant call AddedToCart()
            //jill.AddedToCart(); // does not work
        }
    }
}
