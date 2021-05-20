using SEDC.TryBeingFit.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Domain.Db
{
    public interface IDb<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
        int Insert(T entity);
        void Update(T entity);
        void Remove(int id);
    }
}
