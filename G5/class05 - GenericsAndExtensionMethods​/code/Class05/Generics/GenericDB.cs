using Generics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    public class GenericDB<T> where T : BaseEntity
    {
        public List<T> Db;

        public GenericDB()
        {
            Db = new List<T>();
        }

        public void PrintAll() 
        {
            foreach (T item in Db)
            {
                Console.WriteLine(item.GetInfo());
            }
        }

        public void Insert(T item) 
        {
            Db.Add(item);
            Console.WriteLine($"Item was added in the {item.GetType().Name} Db!");
        }

        public T GetByIndex(int index) 
        {
            return Db[index];
        }

        public T GetById(int id) 
        {
            return Db.Where(item => item.Id == id).FirstOrDefault();
        }

        public void RemoveById(int id) 
        {
            T item = GetById(id);
            if (item == null) 
            {
                Console.WriteLine($"Item was not found in the {item.GetType().Name} Db!");
                return;
            }

            Db.Remove(item);
            Console.WriteLine($"Item was removed from the {item.GetType().Name} Db!");
        }

    }
}
