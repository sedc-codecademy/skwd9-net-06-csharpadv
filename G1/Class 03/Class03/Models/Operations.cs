using Models.Interfaces;

namespace Models
{
    public class Operations : Human, IOperations
    {
        public int NumberOfPcForMaintainence { get; set; }

        public Operations(string firstName, string lastName, long phone, int pcs) : base(firstName, lastName, phone)
        {
            NumberOfPcForMaintainence = pcs;
        }

        public override string GetInfo()
        {
            return $"{FullName} phone: {Phone}";
        }

        public string CheckInfrastructure(string status)
        {
            return $"I am responsible for {NumberOfPcForMaintainence} computers, and status is {status}";
        }
    }
}
