using TryBeingFit.Domain.Enums;
using TryBeingFit.Domain.Interfaces;

namespace TryBeingFit.Domain.Models
{
    public class TrainerUser : User, ITrainerUser
    {
        //public List<LiveTraining> LiveTrainings {get; set;}

        public TrainerUser(string firstName, string lastName, string username, string password) :
            base(firstName, lastName, username, password, UserRole.Trainer)
        {
            //LiveTrainings = new List<LiveTraining>();
        }
    }
}
