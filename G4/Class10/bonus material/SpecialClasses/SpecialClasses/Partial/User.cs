using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialClasses.Partial
{
    public partial class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public User()
        {
            Cart = new List<string>();
        }
        public bool Login(string username, string password)
        {
            if (Username == username && Password == password) return true;
            return false;
        }
        partial void AddedToCart();
    }
}
