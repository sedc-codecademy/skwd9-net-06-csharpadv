using SEDC.TryBeingFit.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.TryBeingFit.Domain.Db
{
    public class LocalDb<T> : IDb<T> where T : BaseEntity
    {
        public int IdCount { get; set; }
        private List<T> _table;

        public LocalDb()
        {
            _table = new List<T>();
            IdCount = 1;
        }

        public List<T> GetAll()
        {
            return _table;
        }

        public T GetById(int id)
        {
            return _table.SingleOrDefault(x => x.Id == id);
        }

        public int Insert(T entity)
        {
            entity.Id = IdCount;
            _table.Add(entity);
            IdCount++;
            return entity.Id;
        }

        public void Remove(int id)
        {
            T item = _table.SingleOrDefault(x => x.Id == id);
            if (item != null)
                _table.Remove(item);
        }

        public void Update(T entity)
        {
            T item = _table.SingleOrDefault(x => x.Id == entity.Id);
            if (item != null)
                item = entity;
        }
    }
}
