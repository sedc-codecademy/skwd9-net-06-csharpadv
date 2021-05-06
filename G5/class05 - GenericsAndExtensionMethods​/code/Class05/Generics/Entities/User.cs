using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public override string GetInfo()
        {
            return $"{Id}) {Username} - {Password}";
        }
    }
}
