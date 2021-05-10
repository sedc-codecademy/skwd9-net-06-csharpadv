using System;
using System.Collections.Generic;
using TryBeingFit.Domain.Models;

namespace TryBeingFit.Domain.Interfaces
{
    public interface ILiveTraining
    {
        DateTime NextSession { get; set; }
        TrainerUser Trainer { get; set; }
        List<PremiumUser> Atendees { get; set; }
    }
}
