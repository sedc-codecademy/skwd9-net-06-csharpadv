using System;
using System.Collections.Generic;
using TryBeingFit.Domain.Models;

namespace TryBeingFit.Domain.Interfaces
{
    public interface ITrainerUser
    {
        List<LiveTraining> LiveTrainings { get; set; }
        void RescheduleTraining(LiveTraining training, DateTime nextSession);
    }
}
