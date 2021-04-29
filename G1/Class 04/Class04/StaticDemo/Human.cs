namespace StaticDemo
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public static string Message => "Welcome"; //{ get; set; }

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        //static Human()
        //{
        //    Message = "";
        //}

        public static string SayHi(string name)
        {
            return $"{Message} {name}";
        }
    }
}
