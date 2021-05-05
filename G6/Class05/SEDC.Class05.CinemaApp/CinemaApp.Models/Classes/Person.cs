using CinemaApp.Models.Interfaces;

namespace CinemaApp.Models.Classes
{
    public abstract class Person : IPersonize
    {
        public Person(string firstName, string lastName)
        {
            ID = _id++;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        private static int _id = 1;
        protected int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public abstract void PrintInfo();
    }
}
