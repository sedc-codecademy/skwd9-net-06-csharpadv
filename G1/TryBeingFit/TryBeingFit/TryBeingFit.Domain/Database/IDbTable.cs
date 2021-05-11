using System.Collections.Generic;
using TryBeingFit.Domain.Models;

namespace TryBeingFit.Domain.Database
{
    public interface IDbTable<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
        int Insert(T entity);
        void RemoveById(int id);
        void Update(T entity);
    }
}
