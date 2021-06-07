using System;
using System.Linq;
using SEDC.TryBeingFit.Domain.Core.Entities;
using SEDC.TryBeingFit.Domain.Db;
using SEDC.TryBeingFit.Services.Helpers;

namespace SEDC.TryBeingFit.Services.Services
{
	public class UserService<T> : IUserService<T> where T : User
	{
		private IDb<T> _db;
		public UserService()
		{
			// This is the code that makes everything work with local db
			// _db = new LocalDb<T>();
			// With one change of a line in the code here we can make all user services work with the File System DB
			_db = new FileSystemDb<T>();
		}
		
		public void ChangeInfo(int userId, string firstName, string lastName)
		{
			T user = _db.GetById(userId);
			if (ValidationHelper.ValidateString(firstName) == null || ValidationHelper.ValidateString(lastName) == null)
			{
				MessageHelper.Color("[Error] strings were not valid. Please try again!", ConsoleColor.Red);
				Console.ReadLine();
				return;
			}
			user.FirstName = firstName;
			user.LastName = lastName;
			_db.Update(user);
			MessageHelper.Color("Data successfuly changed!", ConsoleColor.Green);
			Console.ReadLine();
		}

		public void ChangePassword(int userId, string oldPassword, string newPassword)
		{
			T user = _db.GetById(userId);
			if (user.Password != oldPassword)
			{
				MessageHelper.Color("[Error] Old password did not match", ConsoleColor.Red);
				Console.ReadLine();
				return;
			}
			if (ValidationHelper.ValidateString(newPassword) == null)
			{
				MessageHelper.Color("[Error] New password is not valid", ConsoleColor.Red);
				Console.ReadLine();
				return;
			}
			user.Password = newPassword;
			_db.Update(user);
			MessageHelper.Color("Password successfuly changed!", ConsoleColor.Green);
			Console.ReadLine();
		}

		public T LogIn(string username, string password)
		{
			T user = _db.GetAll().SingleOrDefault(x => x.Username == username && x.Password == password);
			if (user == null)
			{
				MessageHelper.Color("[Error] Username or password did not match!", ConsoleColor.Red);
				Console.ReadLine();
				return null;
			}
			return user;
		}

		public T Register(T user)
		{
			if (ValidationHelper.ValidateString(user.FirstName) == null
				|| ValidationHelper.ValidateString(user.LastName) == null
				|| ValidationHelper.ValidateUsername(user.Username) == null
				|| ValidationHelper.ValidatePassword(user.Password) == null)
			{
				MessageHelper.Color("[Error] Invalid info!", ConsoleColor.Red);
				Console.ReadLine();
				return null;
			}
			int id = _db.Insert(user);
			return _db.GetById(id);
		}

        public T GetById(int id)
        {
            return _db.GetById(id);
        }

		public bool IsDbEmpty()
		{
			return _db.GetAll() == null;
		}
	}
}
