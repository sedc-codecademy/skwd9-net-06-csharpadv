using SEDC.TryBeingFit.Domain.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Domain.Core.Interfaces
{
    public interface IUser
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        UserRole Role { get; set; }
    }
}
