namespace PolymorphismDemo.Entities
{
    public class Dog : Pet
    {
        public bool IsGoodBoi { get; set; }

        public Dog(string name, bool isGoodBoi)
        {
            Name = name;
            IsGoodBoi = isGoodBoi;
        }

        public override string Eat()
        {
            return $"{Name}: I am a dog and I am eating";
        }
    }
}
