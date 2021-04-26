using Static.Enums;

namespace Static.Entities
{
    //non static class
    public class Order
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public OrderStatus Status { get; set; }
        public Order()
        {

        }

        public Order(int id, string description, OrderStatus status)
        {
            //to-do validation
            Id = id;
            Description = description;
            Status = status;
        }
        //static method - belongs to the class
        public static bool IsValid(Order o)
        {
            return o.Id > 0 && string.IsNullOrEmpty(o.Description) == false;
        }
    }
}
