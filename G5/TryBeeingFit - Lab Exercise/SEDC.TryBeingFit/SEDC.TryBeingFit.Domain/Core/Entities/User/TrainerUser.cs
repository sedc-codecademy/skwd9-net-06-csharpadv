using System;
using System.Collections.Generic;
using System.Text;
using SEDC.TryBeingFit.Domain.Core.Entities.Training;
using SEDC.TryBeingFit.Domain.Core.Enum;
using SEDC.TryBeingFit.Domain.Core.Interfaces.User;

namespace SEDC.TryBeingFit.Domain.Core.Entities.User
{
    public class TrainerUser : User, ITrainerUser
    {
        public int YearsOfExperience { get; set; }
        
        public TrainerUser()
        {
            Role = UserRole.Trainer;       
        }

        public bool ChangeSchedule(LiveTraining liveTraining, int days)
        {
            if (days <= 0) return false;
            liveTraining.NextSession = liveTraining.NextSession.AddDays(days);
            return true;
        }

        public override string Print()
        {
            return $"{FirstName} {LastName} - {YearsOfExperience}";
        }
    }
}
