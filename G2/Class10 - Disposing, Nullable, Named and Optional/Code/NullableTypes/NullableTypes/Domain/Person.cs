﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NullableTypes.Domain
{
    public class Person
    {
        public int Id { get; set; }
        public int? Score { get; set; } //nullable int - can get null value
        public bool IsEmployed { get; set; }
        public bool? HasPet { get; set; }
        public string Address { get; set; } //string can get null value, it does not have to be nullable
        public BirthDay? BirthDay { get; set; }
    }
}
