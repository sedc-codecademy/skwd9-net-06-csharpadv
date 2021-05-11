using System;
using System.Collections.Generic;
using System.Text;

namespace EventsExercise.Entities
{
    public class Student
    {
        public string Name { get; set; }
        public Student()
        {

        }
        public Student(string name)
        {
            Name = name;
        }

        public void Hear(string name, int mark)
        {
            if(name == Name)
            {
                Console.WriteLine(mark > 5 ? $"{name}: I passed!!!" : $"{name}: I failed :(");
            }
        }
    }
}
