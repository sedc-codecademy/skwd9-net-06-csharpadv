using ClassGenericsDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassGenericsDemo.Database
{
    public class GenericDb<T> where T : BaseEntity
    {
        private List<T> list;

        public GenericDb()
        {
            list = new List<T>();
        }

        public void Add(T item)
        {
            Console.WriteLine($"LOG: User has entered new {item.GetType().Name} item");
            list.Add(item);
        }

        public void RemoveById(int id)
        {
            T item = list.FirstOrDefault(x => x.Id == id);

            if (item == null)
            {
                Console.WriteLine($"{item.GetType().Name} with id {id} is not found");
            }

            list.Remove(item);
            Console.WriteLine($"LOG: {item.GetType().Name} has been removed");
        }

        public void PrintAll()
        {
            foreach(T item in list)
            {
                Console.WriteLine(item.GetInfo());
            }
        }

        public T GetById(int id)
        {
            return list.FirstOrDefault(x => x.Id == id);
        }

        public T GetByIndex(int index)
        {
            return list[index];
        }
    }
}
