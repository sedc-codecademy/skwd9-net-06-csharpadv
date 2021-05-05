using SEDC.CSharpAdv.VideoRental.Data.Models;

namespace SEDC.CSharpAdv.VideoRental.Services.Interfaces
{
    public interface IUserService
    {
        User Login();
        User SignUp();
    }
}
