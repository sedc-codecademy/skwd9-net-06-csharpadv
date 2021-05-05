using SEDC.CSharpAdv.Class04.Generics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.CSharpAdv.Class04.Generics.DB
{
    public class OrderDb
    {
        private List<Order> Orders { get; set; }

        public OrderDb()
        {
            Orders = new List<Order>();
        }

        public List<Order> GetAll()
        {
            return Orders;
        }

        public void Insert(Order order)
        {
            Orders.Add(order);
        }

        public Order GetById(int id)
        {
            return Orders.FirstOrDefault(o => o.Id == id);
        }
    }
}
