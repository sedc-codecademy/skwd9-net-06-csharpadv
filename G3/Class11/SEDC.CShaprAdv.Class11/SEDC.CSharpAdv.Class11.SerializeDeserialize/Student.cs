using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SEDC.CSharpAdv.Class11.SerializeDeserialize
{
    // Example for our own serializer
    //public class Student
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public int Age { get; set; }
    //    public bool IsPartTime { get; set; }
    //}

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsPartTime { get; set; }

        public Student()
        {

        }

        // Method called on serializing
        [OnSerializing]
        internal void OnSerializeMethod(StreamingContext context)
        {
            Console.WriteLine("WE ARE SERIALIZING A STUDENT");
        }

        // Method called on deserializing
        [OnDeserializing]
        internal void OnDeserializeMethod(StreamingContext context)
        {
            Console.WriteLine("WE ARE DESERIALIZING A STUDENT");

        }
    }
}
