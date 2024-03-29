﻿using System;
using System.Collections.Generic;
using System.Text;
using SEDC.TryBeingFit.Domain.Core.Enums;

namespace SEDC.TryBeingFit.Domain.Core.Models
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
            throw new NotImplementedException();
        }
    }
}
