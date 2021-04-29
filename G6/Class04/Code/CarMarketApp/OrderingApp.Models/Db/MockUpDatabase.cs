using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderingApp.Models.Db
{
    public static class MockUpDatabase
    {
        public static List<User> Users { get; set; }
        public static List<Order> Orders { get; set; }

        static MockUpDatabase()
        {
            Users = new List<User>()
            {
                new User("Damjan"),
                new User("Gorjan"),
                new User("Elena"),
                new User("Bob")
            };

            Orders = new List<Order>()
            {
                new Order("Capri"),
                new Order("Margarita"),
                new Order("Napolitana"),
                new Order("Fungi")
            };

            Users.ForEach(user => user.Orders.Add(Orders[1]));

            foreach (var user in Users)
            {
                if(user.Name == "Bob")
                {
                    user.Orders.Add(Orders[3]);
                }
            }
        }

        public static void PrintAllUsers()
        {
            Console.WriteLine("The users are:");
            Users.ForEach(user => Console.WriteLine(user.Name));
        }

        public static User GetUserByName(string name)
        {
             bool isUserInDb = Users.Any(user => string.Equals(user.Name, name, StringComparison.InvariantCultureIgnoreCase));
            if (!isUserInDb)
            {
                throw new Exception("The user is not in the db");
            }
            User myUser = Users.First(x => x.Name.ToLowerInvariant() == name.ToLowerInvariant());
            return myUser;
        }

        public static int AddUserToDb(string name)
        {
            if(Users.Any(user => string.Equals(user.Name, name, StringComparison.InvariantCultureIgnoreCase)))
            {
                return -1;
            }
            Users.Add(new User(name));
            return 1;
        }
    }
}
