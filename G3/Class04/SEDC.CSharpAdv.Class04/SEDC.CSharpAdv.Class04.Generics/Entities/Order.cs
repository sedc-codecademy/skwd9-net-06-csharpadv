using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class04.Generics.Entities
{
    public class Order : BaseEntity
    {
        public string Receiver { get; set; }
        public string Address { get; set; }

        public override string GetInfo()
        {
            return $"Order with id: {Id} Recevier: {Receiver} Address: {Address}";
        }
    }
}
