using TryBeingFit.Domain.Enums;

namespace TryBeingFit.Domain.Interfaces
{
    public interface IUser
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string FullName { get; }
        string Username { get; set; }
        UserRole Role { get; set; }
    }
}
