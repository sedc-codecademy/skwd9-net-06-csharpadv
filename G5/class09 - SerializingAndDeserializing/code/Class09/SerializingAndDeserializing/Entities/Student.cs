using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SerializingAndDeserializing.Entities
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsPartTime { get; set; }


        // Method will automaticaly be called on serializing
        [OnSerializing]
        internal void OnSerializeMethod(StreamingContext context) 
        {
            Console.WriteLine("We are serializing a STUDENT!");
        }

        // Method will automaticaly be called on deserializing
        [OnDeserializing]
        internal void OnDeserializeMethod(StreamingContext context) 
        {
            Console.WriteLine("We are deserializing a STUDENT!");
        }
    }
}
