﻿using SEDC.TryBeingFit.Domain.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Domain.Core.Entities
{
    public class StandardUser : User
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
