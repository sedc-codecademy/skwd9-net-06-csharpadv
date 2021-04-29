using SEDC.CSharpAdv.Class04.Generics.DB;
using SEDC.CSharpAdv.Class04.Generics.Entities;
using System;

namespace SEDC.CSharpAdv.Class04.Generics
{
    class Program
    {
        public static OrderDb OrderNonGeneric = new OrderDb();
        public static ProductDb ProductNonGeneric = new ProductDb();
        public static UserDb UserNonGeneric = new UserDb();

        public static GenericDb<Order> OrderDb = new GenericDb<Order>();
        public static GenericDb<Product> ProductDb = new GenericDb<Product>();
        public static GenericDb<User> UserDb = new GenericDb<User>();
        public static GenericDb<Example> ExampleDb = new GenericDb<Example>();

        // public static GenericDb<string> GenericDb = new GenericDb<string>();

        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }
}
