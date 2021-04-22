using SEDC.CSharpAdv.Class02.AbstractClassesAndInterfaces.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class02.AbstractClassesAndInterfaces.Entities
{
    public abstract class Human : IHuman
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public long Phone { get; set; }

        public abstract string GetInfo();

        public void Greet(string name)
        {
            Console.WriteLine($"Hey there {name}! My name is {FullName}");
        }

        public Human(string fullname, int age, long phone)
        {
            FullName = fullname;
            Age = age;
            Phone = phone;
        }
    }
}
