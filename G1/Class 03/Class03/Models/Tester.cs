using Models.Interfaces;

namespace Models
{
    public class Tester : Human, ITester
    {
        public int BugsFound { get; set; }

        public Tester(string firstName, string lastName, long phone, int bugsFound) : base(firstName, lastName, phone)
        {
            BugsFound = bugsFound;
        }

        public override string GetInfo()
        {
            return $"{FullName} - found {BugsFound} bugs";
        }

        public string Testing()
        {
            return $"I am testing, I have found {BugsFound} bugs";
        }
    }
}
