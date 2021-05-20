using SEDC.TryBeingFit.Domain.Core.Models;
using SEDC.TryBeingFit.Domain.Db;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Services.Services
{
    public class TraingingService<T> : ITrainingService<T> where T : Training
    {
        private IDb<T> _db;

        public TraingingService()
        {
            _db = new LocalDb<T>();
        }


        public List<T> GetTrainings()
        {
            return _db.GetAll();
        }

        public T GetSingleTraining(int id)
        {
            return _db.GetById(id);
        }

        public void AddTraining(T training)
        {
            _db.Insert(training);
        }
    }
}
