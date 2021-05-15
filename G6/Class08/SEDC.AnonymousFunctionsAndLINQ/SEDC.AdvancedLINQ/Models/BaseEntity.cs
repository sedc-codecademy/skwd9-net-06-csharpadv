using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.AdvancedLINQ.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public abstract string Info();
    }
}
