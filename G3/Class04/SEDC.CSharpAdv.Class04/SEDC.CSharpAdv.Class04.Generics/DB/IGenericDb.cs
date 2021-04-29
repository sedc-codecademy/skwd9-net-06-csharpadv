using SEDC.CSharpAdv.Class04.Generics.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class04.Generics.DB
{
    public interface IGenericDb<T>
        where T : BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
        void Insert(T item);
        T GetByIndex(int index);
        void RemoveById(int id);
        void PrintAll();
    }
}
