using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Admin : Person
    {

        public Admin(string firstName, string lastName, string userName, string password) : base(Role.Admin, firstName, lastName, userName, password)
        {
        }
    }
}
