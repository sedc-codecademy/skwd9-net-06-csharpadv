using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Domain.Core.Interfaces.User
{
    public interface ITrainerUser
    {
        int YearsOfExperience { get; set; }

        //bool ChangeSchedule(LiveTraining liveTraining, int days);
    }
}
