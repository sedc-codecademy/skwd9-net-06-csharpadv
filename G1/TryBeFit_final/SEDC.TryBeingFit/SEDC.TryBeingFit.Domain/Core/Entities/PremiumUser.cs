using System;
using System.Collections.Generic;
using System.Text;
using SEDC.TryBeingFit.Domain.Core.Enums;
using SEDC.TryBeingFit.Domain.Core.Interfaces;

namespace SEDC.TryBeingFit.Domain.Core.Entities
{
	public class PremiumUser : User, IPremiumUser
	{
		public List<VideoTraining> VideoTrainings { get; set; }
		public LiveTraining LiveTraining { get;set; }
		public PremiumUser()
		{
			Role = UserRole.Premium;
		}
		public override string Print()
		{
            return $"{FirstName} {LastName} - A premium user!";
		}
	}
}
