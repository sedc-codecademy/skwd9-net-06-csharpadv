using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Trainer : Person
    {

        public Trainer(string firstName, string lastName, string userName, string password) : base(Role.Trainer, firstName, lastName, userName, password)
        {
        }
    }
}
