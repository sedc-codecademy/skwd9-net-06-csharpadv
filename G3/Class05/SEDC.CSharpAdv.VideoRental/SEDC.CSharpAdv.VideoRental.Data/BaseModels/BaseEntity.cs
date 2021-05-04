using System;

namespace SEDC.CSharpAdv.VideoRental.Data.BaseModels
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }

        public BaseEntity()
        {
            CreatedOn = DateTime.Now;
        }
    }
}
