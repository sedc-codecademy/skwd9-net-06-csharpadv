using SEDC.TryBeingFit.Domain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Domain.Core.Models
{
    public class VideoTraining : Training, IVideoTraining
    {
        public int Raiting { get; set; }
        public string CheckRaiting()
        {
            return Raiting == 1 ? "Bad" :
                   Raiting <= 3 ? "Okay" :
                   Raiting > 3 ? "Good" : "Unknown";
        }

        public override string Print()
        {
            throw new NotImplementedException();
        }
    }
}
