using System;
using System.Collections.Generic;
using System.Text;
using ClassExercise.Entities.Interfaces;

namespace ClassExercise.Entities.Models
{
    public abstract class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User()
        {

        }
        public User(int id, string name, string username, string pass)
        {
            Id = id;
            Name = name;
            Username = username;
            Password = pass;
        }

        public abstract void PrintInfo();
    }
}
