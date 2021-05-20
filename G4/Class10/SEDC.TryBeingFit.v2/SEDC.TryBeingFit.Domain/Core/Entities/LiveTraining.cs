using SEDC.TryBeingFit.Domain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Domain.Core.Entities
{
    public class LiveTraining : Training, ILiveTraining, IVideoTraining
    {
        public DateTime NextSession { get; set; }
        public TrainerUser Trainer { get; set; }

        public string CheckRating()
        {
            if (Rating == 1) return "Bad";
            if (Rating <= 3) return "Okay";
            if (Rating > 3) return "Good";
            return "Unknown";
        }

        public int HoursToNextSession()
        {
            return (NextSession - DateTime.Now).Hours;
        }

        public override string Print()
        {
            return $"[{Difficulty}] {Title} - {Description} with {Trainer.Print()}";
        }
    }
}
