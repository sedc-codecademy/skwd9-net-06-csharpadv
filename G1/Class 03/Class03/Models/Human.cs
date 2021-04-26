using Models.Interfaces;

namespace Models
{
    public abstract class Human : IHuman
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";

        public long Phone { get; set; }

        public Human(string firstName, string lastName, long phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }

        public abstract string GetInfo();
        //{
        //    return $"{FullName} phone: {Phone}";
        //}

        public string Greetings(string name)
        {
            //return $"Hi {FullName}! Welcome to our company";
            return $"Hi {name}, my name is {FullName}";
        }
    }
}
