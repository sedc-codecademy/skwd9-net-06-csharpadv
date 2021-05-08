using System;
using System.Collections.Generic;
using System.Text;

namespace Structs.Entities
{
    // For most of our entities that might:
    // Use inheritance to create a business logic tree ( Inheritance )
    // Use overriding to use a method in different scenarios ( polymorphism )
    // That it has more responsibilities than just storing data
    // Have members that are a refference type ( object )
    // We would always use a Class
    public class User
    {
        public string Username { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
        // Since we created this constructor and we don't have a default one, we can't create User without parameters
        public User(string username, int age, Address address)
        {
            Username = username;
            Age = age;
            Address = address;
        }
        public string GetInfo()
        {
            return $"{Username} ({Age})";
        }
    }
}
