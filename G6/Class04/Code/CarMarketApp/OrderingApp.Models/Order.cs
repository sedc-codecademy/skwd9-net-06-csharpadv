namespace OrderingApp.Models
{
    public class Order
    {
        public Order(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
