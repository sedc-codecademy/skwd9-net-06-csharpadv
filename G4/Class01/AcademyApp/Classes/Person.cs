using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        public Role PersonRole { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        private string Password { get; set; }

        public Person()
        {

        }
        public Person(Role personRole, string firstName, string lastName, string userName, string password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PersonRole = personRole;
            this.UserName = userName;
            this.Password = password;
        }
        public bool ValidatePassword(string pass)
        {
            return this.Password == pass;
        }
        public string GetFullName()
        {
            return $"{this.FirstName} {this.LastName}";
        }
    }
}
