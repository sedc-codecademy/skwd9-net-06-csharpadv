using SEDC.CSharpAdv.Class04.Generics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.CSharpAdv.Class04.Generics.DB
{
    public class ProductDb
    {
        private List<Product> Products { get; set; }

        public ProductDb()
        {
            Products = new List<Product>();
        }

        public List<Product> GetAll()
        {
            return Products;
        }

        public void Insert(Product order)
        {
            Products.Add(order);
        }

        public Product GetById(int id)
        {
            return Products.FirstOrDefault(o => o.Id == id);
        }
    }
}
