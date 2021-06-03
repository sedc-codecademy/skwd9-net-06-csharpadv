using SEDC.TryBeingFit.Domain.Core.Entities;
using SEDC.TryBeingFit.Domain.Db;
using SEDC.TryBeingFit.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Services.Services.Implementations
{
    public class TrainingService<T> : ITrainingService<T> where T : Training
    {
        private IDb<T> _db;
        public TrainingService()
        {
            //_db = new LocalDb<T>();
            _db = new FileSystemDb<T>();
        }
        public void AddTraining(T training)
        {
            _db.Insert(training);
        }

        public T GetSingleTraining(int id)
        {
            return _db.GetById(id);
        }

        public List<T> GetTrainings()
        {
            return _db.GetAll();
        }
    }
}
