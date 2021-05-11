namespace Exercise01.Models
{
    public class Dog : Pet
    {
        public bool GoodBoi { get; set; }
        public string FavoriteFood { get; set; }

        public Dog(string name, int age, bool goodBoi, string favoriteFood) : base(name, PetType.Dog, age)
        {
            GoodBoi = goodBoi;
            FavoriteFood = favoriteFood;
        }

        public override string GetInfo()
        {
            string goodBoi = GoodBoi ? "good boi" : "not good boi";
            return $@"{base.GetInfo()} and is {goodBoi}, and it likes {FavoriteFood}";
        }
    }
}
