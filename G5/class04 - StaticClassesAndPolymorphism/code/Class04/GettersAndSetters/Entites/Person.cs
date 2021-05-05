using System;
using System.Collections.Generic;
using System.Text;

namespace GettersAndSetters.Entites
{
    public class Person
    {
        // The old way

        //private string _name;
        //public string GetName() 
        //{
        //    Console.WriteLine("Getter was triggered.");
        //    return _name + " bonus by getter";
        //}

        //public void SetName(string name) 
        //{
        //    Console.WriteLine("Setter was triggered.");
        //    _name = name + " bonus by setter";
        //}


        // The NEW way

        //public int Age { get; set; }

        private int _age;
        public int Age 
        {
            // The getter is activated everythime when someone is trying to retrieve the value of the property
            get 
            {
                Console.WriteLine("Getter was triggered.");
                return _age;
            }
            // The setter is activated everythime when someone is trying to set the value of the property
            set
            {
                Console.WriteLine("Setter was triggered.");

                if (value == 5)
                {
                    _age = value + 5;
                }
                else 
                {
                    _age = value;
                }  
            }
        }
    }
}
