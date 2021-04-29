using System.Collections.Generic;
using System;
using System.Linq;

namespace OrderingSystem_Models.Db
{
    public static class Storage
    {
        public static List<User> Users { get; set; }

        private static List<Order> OrderSeed { get; set; }

        static Storage()
        {
            Users = new List<User>
            {
                new User("risto"),
                new User("radmila"),
                new User("goran"),
                new User("dejan")
            };

            OrderSeed = new List<Order>
            {
                new Order("Kapricioza"),
                new Order("Peperoni"),
                new Order("Margarita"),
                new Order("Persutio")
            };

            Random rnd = new Random();
            foreach(User u in Users)
            {
                Order o1 = OrderSeed[rnd.Next(0, 4)];
                Order o2 = OrderSeed[rnd.Next(0, 4)];
                u.Orders.Add(o1);
                u.Orders.Add(o2);
            }
        }

        public static string ListAllUsers()
        {
            string info = "Users:\n";
            for(int i = 0; i < Users.Count; i++)
            {
                info += $"{i + 1}. {Users[i].Username}\n";
            }

            return info;
        }

        public static void AddUser(string username)
        {
            //if (Users.Any(x => string.Equals(x.Username, username, StringComparison.InvariantCultureIgnoreCase))) {
            //    throw new Exception("User with that username already exists");
            //}

            Users.Add(new User(username));
        }

        public static User GetUserByUsername(string username)
        {
            if (!Users.Any(x => string.Equals(x.Username, username, StringComparison.InvariantCultureIgnoreCase))) {
                throw new Exception("User with that username does not exists");
            }

            User user = Users.FirstOrDefault(x => string.Equals(x.Username, username, StringComparison.InvariantCultureIgnoreCase));

            if(user == null)
            {
                throw new Exception("User with that username does not exists");
            }

            return user;
        }
    }
}
