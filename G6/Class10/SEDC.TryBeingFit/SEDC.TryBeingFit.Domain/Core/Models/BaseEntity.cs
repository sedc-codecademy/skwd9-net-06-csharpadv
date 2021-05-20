using SEDC.TryBeingFit.Domain.Core.Interfaces;

namespace SEDC.TryBeingFit.Domain.Core.Models
{
    public abstract class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }

        public abstract string Print();
    }
}
