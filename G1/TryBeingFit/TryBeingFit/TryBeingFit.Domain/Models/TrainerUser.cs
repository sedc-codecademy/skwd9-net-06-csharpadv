using System;
using System.Collections.Generic;
using System.Linq;
using TryBeingFit.Domain.Enums;
using TryBeingFit.Domain.Interfaces;

namespace TryBeingFit.Domain.Models
{
    public class TrainerUser : User, ITrainerUser
    {
        public List<LiveTraining> LiveTrainings { get; set; }

        public TrainerUser(string firstName, string lastName, string username, string password) :
            base(firstName, lastName, username, password, UserRole.Trainer)
        {
            LiveTrainings = new List<LiveTraining>();
        }

        public void RescheduleTraining(LiveTraining training, DateTime nextSession)
        {
            if (training.Trainer.Id != Id)
                throw new Exception("You are not trainer of this training");

            //if(!LiveTrainings.Any(x => x.Id == training.Id))
            //    throw new Exception("You are not trainer of this training");

            training.NextSession = nextSession;

            //training.Reschedule(this, nextSession);
        }
    }
}
