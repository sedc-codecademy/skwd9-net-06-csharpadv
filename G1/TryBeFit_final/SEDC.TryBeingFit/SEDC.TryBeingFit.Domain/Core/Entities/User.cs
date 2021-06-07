using System;
using System.Collections.Generic;
using System.Text;
using SEDC.TryBeingFit.Domain.Core.Enums;
using SEDC.TryBeingFit.Domain.Core.Interfaces;

namespace SEDC.TryBeingFit.Domain.Core.Entities
{
	public abstract class User : BaseEntity, IUser
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public UserRole Role { get; set; }
	}
}
