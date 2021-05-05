namespace Demo
{
    public class Human
    {
        //human.Id = 4;
        private string id;
        //H1, H2, H3
        //public string Id {
        //    get => id;
        //    set
        //    {
        //        id = "H" + value;
        //    }
        //}

        public string Id
        {
            get => id;
            set => id = "H" + value;
        }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public string FullName
        //{
        //    get
        //    {
        //        return $"{FirstName} {LastName}";
        //    }
        //}

        //public string FullName => $"{FirstName} {LastName}";

        public string FullName
        {
            get => $"{FirstName} {LastName}";
        }

        public void SetId(string id)
        {
            Id = "H" + id;
        }
        public Address Address { get; set; }

        public Human()
        {
            Address = new Address("Ulica", "1223");
        }
    }

    public struct Address
    {
        public string Street { get; set; }
        public string Number { get; set; }

        public Address(string street, string number)
        {
            Street = street;
            Number = number;
        }

        public string GetAddress()
        {
            return $"{Street} no. {Number}";
        }
    }
}
