namespace SEDC.Class03.Interfaces.ConsoleApp.Models
{
    public abstract class Human
    {
        public Human(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public abstract void CelebrateBirthday();
    }
}
