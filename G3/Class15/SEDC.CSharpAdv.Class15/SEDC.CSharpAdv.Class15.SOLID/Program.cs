using SEDC.CSharpAdv.Class15.SOLID.InterfaceSegregationPrinciple;
using SEDC.CSharpAdv.Class15.SOLID.LiskovSubstitutionPrinciple;
using System;
using System.Collections.Generic;

namespace SEDC.CSharpAdv.Class15.SOLID
{
    class Program
    {
        // SOLID is an acronym for five principles of architecture.
        //
        // S – Single Responsibility Principle
        //
        // O – Open Close Principle
        //
        // L – Liskov Substitution Principle
        //
        // I – Interface Segregation Principle
        //
        // D – Dependency Inversion Principle
        static void Main(string[] args)
        {
            List<ISwitch> list = new List<ISwitch>();
            list.Add(new Cooler());
            list.Add(new Fan());

            foreach (var item in list)
            {
                item.Regulate();
            }

            ITouch touch = new Click();
            IClick click = new Click();

            Console.ReadLine();
        }
    }
}
