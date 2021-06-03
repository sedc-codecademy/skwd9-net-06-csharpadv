using SEDC.TryBeingFit.Domain.Core.Entities.Training;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Services.Services.Interfaces
{
    public interface ITrainingService<T> where T : Training
    {
        List<T> GetTrainings();
        T GetSingleTraining(int id);
        void AddTraining(T training);
        T GetTrainingByIndex(int index);

        bool IsDbEmpty();
    }
}
