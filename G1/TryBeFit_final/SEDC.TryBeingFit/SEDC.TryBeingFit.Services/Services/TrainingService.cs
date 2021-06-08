using System.Collections.Generic;
using SEDC.TryBeingFit.Domain.Core.Entities;
using SEDC.TryBeingFit.Domain.Db;

namespace SEDC.TryBeingFit.Services.Services
{
    public class TrainingService<T> : ITrainingService<T> where T : Training
    {
        private IDb<T> _db;
        public TrainingService()
        {
            // This is the code that makes everything work with local db
            // _db = new LocalDb<T>();
            // With one change of a line in the code here we can make all user services work with the File System DB
            _db = new FileSystemDb<T>();
        }

        public List<T> GetTrainings()
        {
            return _db.GetAll();
        }

        public T GetSingleTraining(int id)
        {
            T training = _db.GetById(id);
            return training;
        }
        public void AddTraining(T training)
        {
            _db.Insert(training);
        }
    }
}
