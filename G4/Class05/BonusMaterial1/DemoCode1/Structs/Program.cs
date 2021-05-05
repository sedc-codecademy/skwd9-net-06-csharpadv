using Structs.Entities;
using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address("Bob Street", 11);
            // Address address = new Address() { Street = "Bob Street", Number = 11 }; // This also works
            User bob = new User("BobBest", 21, address);
            //User bob = new User() { Username = "BobBest", Age = 21, Address = address }; // This does not work

            Console.WriteLine(bob.GetInfo());
            Console.WriteLine(address.GetFullAddress());

            Address newAddress = address;
            newAddress.Number = 50;
            newAddress.Street = "New Street";

            User bob2 = bob;
            bob2.Username = "New Bob";
            bob2.Age = 45;
            Console.WriteLine("----------after changes-----------");

            Console.WriteLine(bob.GetInfo());
            Console.WriteLine(address.GetFullAddress());

            Console.ReadLine();
        }
    }
}
