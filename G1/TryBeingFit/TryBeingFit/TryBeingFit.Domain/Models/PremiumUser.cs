using System.Collections.Generic;
using TryBeingFit.Domain.Enums;
using TryBeingFit.Domain.Interfaces;

namespace TryBeingFit.Domain.Models
{
    public class PremiumUser : User, IPremiumUser
    {
        public List<VideoTraining> VideoTrainings { get; set; }
        public List<LiveTraining> LiveTrainings { get; set; }

        public PremiumUser(string firstName, string lastName, string username, string password) :
            base(firstName, lastName, username, password, UserRole.Premium)
        {
            VideoTrainings = new List<VideoTraining>();
            LiveTrainings = new List<LiveTraining>();
        }
    }
}
