using SEDC.TryBeingFit.Domain.Core.Enums;
using SEDC.TryBeingFit.Domain.Core.Interfaces;
using System;

namespace SEDC.TryBeingFit.Domain.Core.Models
{
    public class TrainerUser : User, ITrainerUser
    {
        public int YearsOfExperience { get; set; }

        public TrainerUser()
        {
            Role = UserRole.Trainer;
        }

        public bool ChangeSchedule(LiveTraining training, int days)
        {
            if (days <= 0)
                return false;
            training.NextSession = training.NextSession.AddDays(days);
            return true;
        }

        public override string Print()
        {
            throw new NotImplementedException();
        }
    }
}
