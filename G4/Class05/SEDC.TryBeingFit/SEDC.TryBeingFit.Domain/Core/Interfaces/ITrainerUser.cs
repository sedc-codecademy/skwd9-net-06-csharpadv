using SEDC.TryBeingFit.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Domain.Core.Interfaces
{
    public interface ITrainerUser
    {
        bool ChangeSchedule(LiveTraining liveTraining, int days);
    }
}
