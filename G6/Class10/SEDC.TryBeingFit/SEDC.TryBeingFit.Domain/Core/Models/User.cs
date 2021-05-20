using SEDC.TryBeingFit.Domain.Core.Enums;
using SEDC.TryBeingFit.Domain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Domain.Core.Models
{
    public class User : BaseEntity, IUser
    {
        public string FirstName { get; set ; }
        public string LastName { get; set; }
        public string UserName { get ; set; }
        public string Password { get; set ; }
        public UserRole Role { get; set; }

        public override string Print()
        {
            throw new NotImplementedException();
        }
    }
}
