namespace OrderingSystem_Models
{
    public class Order
    {
        public string Name { get; set; }

        public Order(string name)
        {
            Name = name;
        }
    }
}
