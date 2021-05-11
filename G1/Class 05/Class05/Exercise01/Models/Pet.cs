namespace Exercise01.Models
{
    public abstract class Pet : IPet
    {
        public string Name { get; set; }
        public PetType Type { get; set; }
        public int Age { get; set; }

        public virtual string GetInfo() {
            return $"[{Type}] {Name} age {Age}";
        }

        public Pet(string name, PetType type, int age)
        {
            Name = name;
            Type = type;
            Age = age;
        }
    }
}
