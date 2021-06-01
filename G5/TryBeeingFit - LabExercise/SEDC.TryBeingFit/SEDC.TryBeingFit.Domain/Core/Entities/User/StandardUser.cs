﻿using System;
using System.Collections.Generic;
using System.Text;
using SEDC.TryBeingFit.Domain.Core.Entities.Training;
using SEDC.TryBeingFit.Domain.Core.Enum;
using SEDC.TryBeingFit.Domain.Core.Interfaces.User;

namespace SEDC.TryBeingFit.Domain.Core.Entities.User
{
    public class StandardUser : User, IStandardUser
    {
        public List<VideoTraining> VideoTrainings { get; set; }
        public StandardUser()
        {
            Role = UserRole.Standard;
        }

        public override string Print()
        {
            return $"{FirstName} {LastName}";
        }
    }
}