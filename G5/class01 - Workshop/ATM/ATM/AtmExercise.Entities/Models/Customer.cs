using System;
using System.Collections.Generic;
using System.Text;
using AtmExercise.Entities.Enums;

namespace AtmExercise.Entities.Models
{
    public class Customer : User
    {
        public long CardNumber { get; set; }
        public short Pin { get; set; }
        private int AccountBalance { get; set; }

        public Customer(string firstName, string lastName, long cardNumber, short pin, int accountBalance) : base(firstName, lastName, Role.Customer)
        {
            CardNumber = cardNumber;
            Pin = pin;
            AccountBalance = accountBalance;
        }

        public int GetUserBalance()
        {
            return AccountBalance;
        }

        public bool WithdrawFromAccount(int ammount)
        {
            if (ammount <= AccountBalance)
            {
                AccountBalance -= ammount;
                return true;
            }

            return false;
        }

        public bool DepositMoneyToAccount(int ammount)
        {
            if (ammount < 1)
            {
                return false;
            }

            AccountBalance += ammount;
            return true;
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
