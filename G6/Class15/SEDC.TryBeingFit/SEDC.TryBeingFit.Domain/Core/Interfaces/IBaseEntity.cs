using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Domain.Core.Interfaces
{
    public interface IBaseEntity
    {
        int Id { get; set; }
        string Print();
    }
}
