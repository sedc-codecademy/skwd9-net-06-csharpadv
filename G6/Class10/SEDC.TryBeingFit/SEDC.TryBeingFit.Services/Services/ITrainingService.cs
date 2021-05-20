using SEDC.TryBeingFit.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Services.Services
{
    public interface ITrainingService<T> where T : Training
    {
        List<T> GetTrainings();
        T GetSingleTraining(int id);
        void AddTraining(T training);
    }
}
