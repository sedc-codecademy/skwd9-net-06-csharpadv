using SEDC.TryBeingFit.Domain.Core.Entities;
using SEDC.TryBeingFit.Domain.Db.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.TryBeingFit.Domain.Db.Classes
{
    public class LocalDb<T> : IDb<T> where T : BaseEntity
    {
        public int IdCounter { get; set; }
        private List<T> Db;

        public LocalDb()
        {
            Db = new List<T>();
            IdCounter = 1;
        }

        public List<T> GetAll()
        {
            return Db;
        }

        public T GetById(int id)
        {
            return Db.SingleOrDefault(x => x.Id == id);
        }

        public int Insert(T entity)
        {
            entity.Id = IdCounter;
            Db.Add(entity);
            IdCounter++;
            return entity.Id;
        }

        public void RemoveById(int id)
        {
            T item = GetById(id);
            if (item != null) Db.Remove(item);
        }

        public void Update(T entity)
        {
            T item = GetById(entity.Id);
            item = entity;
        }
    }
}
