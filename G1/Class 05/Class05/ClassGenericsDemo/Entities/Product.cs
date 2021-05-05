using System;
using System.Collections.Generic;
using System.Text;

namespace ClassGenericsDemo.Entities
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public override string GetInfo()
        {
            return $"({Id}) {Title} - {Description}";
        }
    }
}
