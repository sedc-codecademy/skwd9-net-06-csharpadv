using System;
using System.Collections.Generic;
using System.Text;
using SEDC.TryBeingFit.Domain.Core.Enum;
using SEDC.TryBeingFit.Domain.Core.Interfaces.Training;

namespace SEDC.TryBeingFit.Domain.Core.Entities.Training
{
    public abstract class Training : BaseEntity, ITraining
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Time { get; set; }
        public Difficulty Difficulty { get; set; }
        public int Raiting { get; set; }

        public string CheckRaiting()
        {
            if (Raiting == 1) return "Bad";
            if (Raiting < 3) return "Okey";
            if (Raiting > 3) return "Good";
            return "Unknown";
        }
    }
}
