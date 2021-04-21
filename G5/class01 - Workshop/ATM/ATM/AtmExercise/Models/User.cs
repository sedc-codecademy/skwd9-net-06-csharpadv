using System;
using System.Collections.Generic;
using System.Text;

namespace AtmExercise.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long CardNumber { get; set; }
        public short Pin { get; set; }
        public int AccountBalance { get; set; }

        public User(string firstName, string lastName, long cardNumber, short pin, int accountBalance)
        {
            FirstName = firstName;
            LastName = lastName;
            CardNumber = cardNumber;
            Pin = pin;
            AccountBalance = accountBalance;
        }

        public string GetFullName() 
        {
            return $"{FirstName} {LastName}";
        }

        public bool CheckPin(short pin) 
        {
            if (Pin == pin) 
            {
                return true;
            }

            return false;
        }
    }
}
