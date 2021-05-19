using TryBeingFit.Domain.Models;

namespace TryBeingFit.Services.Interfaces
{
    public interface IUserService<T> where T : User
    {
        T Login(string username, string password);
        T Register(T user);
        void ChangePassword(int userId, string oldPassword, string newPassword);
        void ChangeInfo(int userId, string firstName, string lastName);
    }
}
