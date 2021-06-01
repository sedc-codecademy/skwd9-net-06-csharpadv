using SEDC.CSharpAdv.VideoRental.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.CSharpAdv.VideoRental.Data.Database
{
    public abstract class GenericRepository<T>
        where T : BaseEntity
    {
        protected readonly IFileDatabase<T> _db;

        public GenericRepository()
        {
            _db = new FileDatabase<T>();
        }

        // CRUD -> Create Read Update Delete
        
        // read
        public List<T> GetAll()
        {
            return _db.Read();
        }

        //read
        public T GetById(int id)
        {
            return _db.Read().FirstOrDefault(x => x.Id == id);
        }

        //create
        public int Insert(T entity)
        {

            entity.Id = ++_db.Id;
            var data = _db.Read();
            data.Add(entity);
            bool isAdded = _db.Write(data);
            if(isAdded)
            {
                return entity.Id;
            }
            return 0;
        }

        //update
        public void Update(T entity)
        {
            var data = _db.Read();
            var dbEntity = data.FirstOrDefault(x => x.Id == entity.Id);
            if(dbEntity != null)
            {
                data.Remove(dbEntity);
                data.Add(entity);
            }
            _db.Write(data.OrderBy(x => x.Id).ToList());
            // TODO: Throw error if entity does not exists
        }

        //delete
        public bool Remove(T entity)
        {
            var data = _db.Read();
            var prevLength = data.Count;
            data.Remove(entity);
            _db.Write(data);
            return prevLength != data.Count;
        }

        // filtering functions
        public List<T> Filter(Func<T,bool> filter)
        {
            return _db.Read().Where(filter).ToList();
        }
    }
}
