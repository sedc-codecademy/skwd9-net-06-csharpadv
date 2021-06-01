﻿using System;
using System.Collections.Generic;
using System.Text;
using SEDC.TryBeingFit.Domain.Core.Entities.Training;
using SEDC.TryBeingFit.Domain.Core.Enum;
using SEDC.TryBeingFit.Domain.Core.Interfaces.User;

namespace SEDC.TryBeingFit.Domain.Core.Entities.User
{
    public class PremiumUser : User, IStandardUser, IPremiumUser
    {
        public List<VideoTraining> VideoTrainings { get; set; }

        public LiveTraining LiveTraining { get; set; }

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