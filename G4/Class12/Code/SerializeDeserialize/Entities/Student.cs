using System;
using System.Collections.Generic;
using System.Text;

namespace SerializeDeserialize.Entities
{
    // Example for our serializer
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsPartTime { get; set; }
    }
}
