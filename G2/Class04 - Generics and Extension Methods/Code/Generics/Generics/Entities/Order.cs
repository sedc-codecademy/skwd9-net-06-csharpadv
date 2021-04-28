

namespace Generics.Entities
{
    public class Order : BaseEntity
    {
        public string Address { get; set; }
        public string Receiver { get; set; }
        public override string GetInfo()
        {
            return $"{Id} {Address} {Receiver}";
        }
    }
}
