namespace ClassGenericsDemo.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }

        public override string GetInfo()
        {
            return $"({Id}) {Name}";
        }
    }
}
