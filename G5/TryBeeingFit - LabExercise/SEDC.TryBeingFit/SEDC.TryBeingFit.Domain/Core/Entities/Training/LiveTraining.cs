using System;
using System.Collections.Generic;
using System.Text;
using SEDC.TryBeingFit.Domain.Core.Entities.User;
using SEDC.TryBeingFit.Domain.Core.Interfaces.Training;

namespace SEDC.TryBeingFit.Domain.Core.Entities.Training
{
    public class LiveTraining : Training, ILiveTraining, IVideoTraining
    {
        public DateTime NextSession { get; set; }
        public TrainerUser Trainer { get; set; }
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
