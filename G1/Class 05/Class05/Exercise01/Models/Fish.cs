namespace Exercise01.Models
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public int Size { get; set; }

        public Fish(string name, int age, string color, int size) : base(name, PetType.Fish, age)
        {
            Color = color;
            Size = size;
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()}  is {Color} and size {Size} cm";
        }
    }
}
