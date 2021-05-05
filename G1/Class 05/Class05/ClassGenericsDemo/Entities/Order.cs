using System;
using System.Collections.Generic;
using System.Text;

namespace ClassGenericsDemo.Entities
{
    public class Order : BaseEntity
    {
        public string Receiver { get; set; }
        public string Address { get; set; }

        public override string GetInfo()
        {
            return $"({Id}) {Receiver} - {Address}";
        }
    }
}
