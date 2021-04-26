using Models.Interfaces;
using System.Collections.Generic;

namespace Models
{
    public class QaEngineer : Human, IDeveloper, ITester
    {
        public List<string> Frameworks { get; set; }

        public QaEngineer(string firstName, string lastName, long phone, List<string> frameworks) : base(firstName, lastName, phone)
        {
            Frameworks = frameworks;
        }

        public override string GetInfo()
        {
            return $"{FullName} knows {string.Join(",", Frameworks)} frameworks";
        }

        public string Codeing()
        {
            return $"I am coding automation UI test";
        }

        public string Testing()
        {
            return $"I have run the tests";
        }
    }
}
