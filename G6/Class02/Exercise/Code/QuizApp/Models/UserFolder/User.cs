using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class User
    {
        public Role Role { get; set; }
        public string Username { get; set; }
        protected string Password { get; set; }

        public User() { }
        public User(Role role)
        {
            Role = role;
        }
       public User(Role role, string usern, string pass)
        {
            Role = role;
            Username = usern;
            Password = pass; ;
        }
        public bool PassCheck(string pass)
        {
            if(Password == pass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
