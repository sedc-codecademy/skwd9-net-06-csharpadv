namespace PolymorphismDemo.Entities
{
    public class Cat : Pet
    {
        public bool IsLazy { get; set; }

        public override string Eat()
        {
            return $"Hi, my name is {Name} the cat and I am eating";
        }
    }
}
