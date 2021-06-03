using System;
using System.Collections.Generic;
using System.Text;
using SEDC.TryBeingFit.Domain.Core.Entities.Training;
using SEDC.TryBeingFit.Domain.Db.Classes;
using SEDC.TryBeingFit.Domain.Db.Interfaces;
using SEDC.TryBeingFit.Services.Services.Interfaces;

namespace SEDC.TryBeingFit.Services.Services.Classes
{
    public class TrainingService<T> : ITrainingService<T> where T : Training
    {
        private IDb<T> Database { get; set; }

        public TrainingService()
        {
            //Database = new LocalDb<T>();
            Database = new FileSystemDb<T>();
        }

        public List<T> GetTrainings()
        {
            return Database.GetAll();
        }

        public T GetSingleTraining(int id)
        {
            return Database.GetById(id);
        }

        public void AddTraining(T training)
        {
            Database.Insert(training);
        }

        public T GetTrainingByIndex(int index) 
        {
            return Database.GetAll()[index];
        }

        public bool IsDbEmpty() 
        {
            return Database.GetAll() == null;
        }

    }
}
