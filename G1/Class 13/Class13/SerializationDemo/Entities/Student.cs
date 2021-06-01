using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SerializationDemo.Entities
{
    public class Student
    {
        //[JsonProperty("Ime")]
        public string FirstName { get; set; }
        //[JsonProperty("Prezime")]
        public string LastName { get; set; }
        //[JsonProperty("CeloIme")]
        public string FullName => $"{FirstName} {LastName}";
        //[JsonProperty("Godini")]
        public int Age { get; set; }
        //[JsonProperty("Aktiven")]
        public bool Active { get; set; }
        public List<Subject> Subjects { get; set; }

        //[OnSerializing]
        //internal void OnSerializeMethod(StreamingContext context)
        //{
        //    Console.WriteLine("We are serializing the student object");
        //}


        //[OnDeserializing]
        //internal void OnDeserializeMethod(StreamingContext context)
        //{
        //    Console.WriteLine("We are deserializing the student object");
        //}


        //[OnSerialized]
        //internal void OnSerializedMethod(StreamingContext context)
        //{
        //    Console.WriteLine("Serialization done");
        //}


        //[OnDeserialized]
        //internal void OnDeserializedMethod(StreamingContext context)
        //{
        //    Console.WriteLine("Deserialized done");
        //}
    }
}
