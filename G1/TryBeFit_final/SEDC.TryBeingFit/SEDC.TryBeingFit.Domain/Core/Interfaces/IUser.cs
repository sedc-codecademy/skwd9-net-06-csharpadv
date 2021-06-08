using SEDC.TryBeingFit.Domain.Core.Enums;

namespace SEDC.TryBeingFit.Domain.Core.Interfaces
{
	public interface IUser
	{
		string FirstName { get; set; }
		string LastName { get; set; }
		string Username { get; set; }
		string Password { get; set; }
		UserRole Role { get; set; }
	}
}
