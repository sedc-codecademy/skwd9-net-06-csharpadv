using SEDC.TryBeingFit.Domain.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Domain.Core.Models
{
    public class PremiumUser : User
    {
        // TODO: Chagne the string type into the appropriate video type later
        public List<VideoTraining> VideoTrainings { get; set; }
        public LiveTraining LiveTraining { get; set; }

        public PremiumUser()
        {
            Role = UserRole.Premium;
        }

        public override string Print()
        {
            throw new NotImplementedException();
        }
    }
}
