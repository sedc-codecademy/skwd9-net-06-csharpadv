using Generics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    public static class GenericDb<T> where T: BaseEntity
    {
        public static List<T> Table;
        static GenericDb()
        {
            Table = new List<T>();
        }

        public static void PrintAll()
        {
            foreach(T item in Table)
            {
                Console.WriteLine(item.GetInfo());
            }
        }

        public static void Insert(T item)
        {
            T existingItem = Table.FirstOrDefault(x => x.Id == item.Id);
            if(existingItem != null)
            {
                Console.WriteLine($"There already exists a member with id: {item.Id}");
                return;
            }
            Table.Add(item);
            Console.WriteLine("Item added");
        }

        public static T GetByIndex(int index)
        {
            return Table[index];
        }

        public static T GetById(int id)
        {
            return Table.FirstOrDefault(x => x.Id == id);
        }

        public static void Remove(int id)
        {
            T existingItem = Table.FirstOrDefault(x => x.Id == id);
            if (existingItem == null)
            {
                Console.WriteLine($"A member with id: {id} does not exist");
                return;
            }
            Table.Remove(existingItem);
            Console.WriteLine("Item removed");
        }

    }
}
