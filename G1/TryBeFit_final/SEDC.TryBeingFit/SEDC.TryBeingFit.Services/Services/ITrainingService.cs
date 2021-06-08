using System.Collections.Generic;
using SEDC.TryBeingFit.Domain.Core.Entities;

namespace SEDC.TryBeingFit.Services.Services
{
    public interface ITrainingService<T> where T : Training
    {
        List<T> GetTrainings();
        T GetSingleTraining(int id);
        void AddTraining(T training);
    }
}
