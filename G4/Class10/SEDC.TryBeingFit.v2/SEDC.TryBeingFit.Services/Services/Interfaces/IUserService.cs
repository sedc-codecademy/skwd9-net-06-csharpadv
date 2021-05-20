using SEDC.TryBeingFit.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Services.Services.Interfaces
{
    public interface IUserService<T> where T : User
    {
        void ChangeInfo(int userId, string firstName, string lastName);
        T Login(string username, string password);
        T Register(T user);
        void ChangePassword(int userId, string oldPassword, string newPassword);
        T GetById(int id);
        bool IsDbEmpty();
    }
}
