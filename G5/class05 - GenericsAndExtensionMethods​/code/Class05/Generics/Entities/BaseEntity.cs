using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public abstract string GetInfo();
    }
}
