using System;
using TryBeingFit.Domain.Interfaces;

namespace TryBeingFit.Domain.Models
{
    public abstract class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }

        public abstract string GetInfo();

        public BaseEntity()
        {
            //Random rnd = new Random();
            //Id = rnd.Next(1, int.MaxValue);
        }
    }
}
