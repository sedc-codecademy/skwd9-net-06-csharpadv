namespace CinemaApp.Models.Classes
{
    public class User : Person
    {
        public User(string firstName, string lastName, string address, string phoneNumber, decimal billance, string username, string password) : base(firstName, lastName)
        {

        }

        public User(string firstname, string lastname,string username, string password) : base(firstname,lastname)
        {
            this.Username = username;
            this.Password = password;
            if (string.IsNullOrEmpty(this.Username))
            {
                this.Username = "user1";
            }
        }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsLoggedIn { get; set; }
        public decimal Billance { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public override void PrintInfo()
        {
            System.Console.WriteLine($"{this.FirstName} {this.LastName} is a user of the application");
        }

        public int GetUserId()
        {
            return this.ID;
        }
    }
}
