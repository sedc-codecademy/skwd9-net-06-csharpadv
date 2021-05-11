using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01.Models
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }

        public Cat(string name, int age, bool lazy, int livesLeft) : base(name, PetType.Cat, age)
        {
            Lazy = lazy;
            LivesLeft = livesLeft;
        }

        public override string GetInfo()
        {
            string isLazy = Lazy ? "lazy" : "not lazy";
            return $"{base.GetInfo()}  and is {isLazy}";
        }
    }
}
