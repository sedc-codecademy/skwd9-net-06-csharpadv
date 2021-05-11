using System;
using System.Collections.Generic;
using TryBeingFit.Domain.Enums;
using TryBeingFit.Domain.Interfaces;

namespace TryBeingFit.Domain.Models
{
    public class LiveTraining : Training, ILiveTraining
    {
        public DateTime NextSession { get; set; }
        public TrainerUser Trainer { get; set; }
        public List<PremiumUser> Atendees { get; set; }

        public LiveTraining(string title, string description, int duration, Difficulty difficulty, string link, TrainerUser trainer, DateTime firstSession)
            : base(title, description, duration, TrainingType.Live, difficulty, link)
        {
            NextSession = firstSession;
            Trainer = trainer;
            Atendees = new List<PremiumUser>();
        }

        //public void Reschedule(TrainerUser trainer, DateTime nextSession)
        //{
        //    if (Trainer.Id != trainer.Id)
        //        throw new Exception("You are not trainer of this training");

        //    NextSession = nextSession;
        //}
    }
}
