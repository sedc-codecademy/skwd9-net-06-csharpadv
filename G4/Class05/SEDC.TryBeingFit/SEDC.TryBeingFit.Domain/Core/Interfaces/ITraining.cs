using SEDC.TryBeingFit.Domain.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Domain.Core.Interfaces
{
    public interface ITraining
    {
        string Title { get; set; }
        string Description { get; set; }
        int Time { get; set; }
        Difficulty Difficulty { get; set; }
    }
}
