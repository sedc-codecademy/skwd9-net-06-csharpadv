using SEDC.TryBeingFit.Domain.Core.Enums;
using SEDC.TryBeingFit.Domain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Domain.Core.Entities
{
    public class TrainerUser : User, ITrainerUser
    {
        public int YearsExperience { get; set; }

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
            return $"{FirstName} {LastName} - {YearsExperience} years experience";
        }
    }
}
