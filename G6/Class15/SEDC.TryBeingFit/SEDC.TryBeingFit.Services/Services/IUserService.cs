using SEDC.TryBeingFit.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Services.Services
{
    public interface IUserService<T> where T : User
    {
        T Register(T user);
        T LogIn(string username, string password);
        T GetUserById(int id);
        void ChangePassword(int userId, string oldPassword, string newPassword);
        void ChangeInfo(int userId, string firstName, string lastName);
    }
}
