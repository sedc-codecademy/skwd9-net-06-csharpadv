using SEDC.CSharpAdv.VideoRental.Data.Database;
using SEDC.CSharpAdv.VideoRental.Data.Models;
using SEDC.CSharpAdv.VideoRental.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.VideoRental.Services.Services
{
    public class UserService : IUserService
    {
        private UserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public User Login()
        {
            throw new NotImplementedException();
        }

        public User SignUp()
        {
            throw new NotImplementedException();
        }
    }
}
