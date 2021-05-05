using System;
using System.Collections.Generic;
using System.Text;

// namespace SEDC.CSharpAdv.Class04.Extensions.Piggybacking
namespace SEDC.CSharpAdv.Class04.Extensions.Entites
{
    public static class ProductHelpers
    {
        public static void PrintProductId(this Product product)
        {
            Console.WriteLine(product.Id);
        }
    }
}
