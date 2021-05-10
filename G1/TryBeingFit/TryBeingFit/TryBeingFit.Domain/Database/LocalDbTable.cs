using System.Collections.Generic;
using System.Linq;
using TryBeingFit.Domain.Models;

namespace TryBeingFit.Domain.Database
{
    public class LocalDbTable<T> : IDbTable<T> where T : BaseEntity
    {
        private List<T> table;
        private int idCounter;

        public LocalDbTable()
        {
            table = new List<T>();
            idCounter = 1;
        }

        public List<T> GetAll()
        {
            //List<T> newList = new List<T>();
            //foreach(T item in table)
            //{
            //    newList.Add(item);
            //}

            //return newList;
            return table;
        }

        public T GetById(int id)
        {
            T item = table.FirstOrDefault(x => x.Id == id);
            return item;
        }

        public int Insert(T entity)
        {
            //if (table.Any(x => x.Id == entity.Id))
            //    return entity.Id;

            //table.Add(entity);
            //return entity.Id;

            entity.Id = idCounter;
            idCounter++;
            table.Add(entity);
            return entity.Id;
        }

        public void RemoveById(int id)
        {
            T item = table.FirstOrDefault(x => x.Id == id);

            //if (item == null)
            //    return;

            if (item != null)
            {
                table.Remove(item);
            }
        }

        public void Update(T entity)
        {
            T item = table.FirstOrDefault(x => x.Id == entity.Id);
            item = entity;
        }
    }
}
