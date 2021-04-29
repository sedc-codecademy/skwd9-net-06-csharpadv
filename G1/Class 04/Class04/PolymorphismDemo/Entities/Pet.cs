namespace PolymorphismDemo.Entities
{
    public class Pet
    {
        public string Name { get; set; }
        public virtual string Eat()
        {
            return $"{Name} is eating!";
        }
    }
}
