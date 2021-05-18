using SEDC.TryBeingFit.Domain.Core.Interfaces.Training;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Domain.Core.Entities.Training
{
    public class VideoTraining : Training, IVideoTraining
    {
        public string Link { get; set; }
        public override string Print()
        {
            return $"[{Difficulty}] {Title} - {Description}";
        }
    }
}
