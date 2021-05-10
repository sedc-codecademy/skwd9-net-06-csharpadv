using System.Collections.Generic;
using TryBeingFit.Domain.Enums;
using TryBeingFit.Domain.Interfaces;

namespace TryBeingFit.Domain.Models
{
    public class StandardUser : User, IStandardUser
    {
        public List<VideoTraining> VideoTrainings { get; set; }

        public StandardUser(string firstName, string lastName, string username, string password) :
            base(firstName, lastName, username, password, UserRole.Standard)
        {
            VideoTrainings = new List<VideoTraining>();
        }
    }
}
