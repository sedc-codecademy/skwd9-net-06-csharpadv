using System;
using System.Collections.Generic;
using System.Text;
using SEDC.TryBeingFit.Domain.Core.Entities.User;

namespace SEDC.TryBeingFit.Services.Services.Interfaces
{
    public interface IUserService<T> where T : User
    {
        T Login(string username, string password);
        T Register(T user);
        void ChangePassword(int id, int oldPassword, int newPassword);
        void ChangeInfo(int id, string firstName, string lastName);
        bool IsDbEmpty();
    }
}
