using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialClasses.Partial
{
    public partial class User
    {
        public List<string> Cart { get; set; }
        public int BonusCardNumber { get; set; }
        public void ShowCart()
        {
            Console.WriteLine($"Hello {Username}! This is your cart:");
            foreach (var item in Cart)
            {
                Console.WriteLine(item);
            }
        }
        public void ProductToCart(string product)
        {
            Cart.Add(product);
            AddedToCart();
        }
        partial void AddedToCart()
        {
            Console.WriteLine("A product was added to the cart!");
        }
    }
}
