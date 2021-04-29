using SEDC.CSharpAdv.Class04.Generics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.CSharpAdv.Class04.Generics.DB
{
    public class GenericDb<T>
        where T : BaseEntity
    {
        private List<T> Db { get; set; }

        public GenericDb()
        {
            Db = new List<T>();
        }

        public List<T> GetAll()
        {
            return Db;
        }

        public T GetById(int id)
        {
            T item = Db.FirstOrDefault(x => x.Id == id);
            return item;
        }

        public void Insert(T item)
        {
            Db.Add(item);
        }

        public T GetByIndex(int index)
        {
            return Db[index];
        }

        public void RemoveById(int id)
        {
            T item = Db.FirstOrDefault(item => item.Id == id);
            if(item == null)
            {
                return;
            }
            Db.Remove(item);
        }

        public void PrintAll()
        {
            foreach(T item in Db)
            {
                Console.WriteLine(item.GetInfo());
            }
        }
    }

    public class Test<T>
    {
    }
}
