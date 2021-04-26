using Static.Entities;
using Static.Enums;
using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            //User user = new User()
            //{
            //    Id = 1,
            //    Username = "martinm"
            //};
            //Order pizzaOrder = new Order() { Id = 2, Status = Enums.OrderStatus.Delivered, Description = "Pizza Capri" };
            //user.Orders.Add(pizzaOrder);
            //user.Orders.Add(new Order() { Id = 3, Status = Enums.OrderStatus.Processed, Description = "Bread" });
            //user.PrintOrders();

            //Console.WriteLine(Order.IsValid(pizzaOrder));
            Console.WriteLine("Welcome");
            if (TextHelper.NumOfMessagesGenerated > 0)
            {
                Console.WriteLine($"{TextHelper.NumOfMessagesGenerated} people have checked their orders");
            }
            Console.WriteLine("Choose user");
            OrdersDb.PrintAllUsers();

            string input = Console.ReadLine();
            int choice = TextHelper.ValidateInput(input);
            if(choice == -1)
            {
                throw new Exception("Inavlid input");
            }
            if(choice > 2)
            {
                throw new Exception("Inavlid choice");
            }

            User currentUser = OrdersDb.Users[choice - 1];

            Console.WriteLine("Choose option: 1) See order status, 2) Add an order");
            string optionInput = Console.ReadLine();
            int option = TextHelper.ValidateInput(optionInput);
            if (option == -1)
            {
                throw new Exception("Inavlid option");
            }
            if(option == 1)
            {
                Console.WriteLine("Choose an order");
                currentUser.PrintOrders();
                string orderInput = Console.ReadLine();
                int orderNumber = TextHelper.ValidateInput(orderInput);
                if (orderNumber == -1)
                {
                    throw new Exception("Inavlid order number");
                }
                //validation 1-3
                TextHelper.GenerateStatusMessage(currentUser.Orders[orderNumber - 1].Status);
                Console.WriteLine(TextHelper.NumOfMessagesGenerated);
                Console.ReadLine();
            }
            else
            {
                Order newOrder = new Order();
                Console.WriteLine("Enter description");
                newOrder.Description = Console.ReadLine();
                newOrder.Status = OrderStatus.Processed;
                Console.WriteLine($"Num of orders for user: {currentUser.Orders.Count}");
                OrdersDb.AddOrder(currentUser.Id, newOrder);
                Console.WriteLine($"Num of orders: {OrdersDb.Orders.Count}");
                Console.WriteLine($"Num of orders for user: {currentUser.Orders.Count}");
            }

            Console.ReadLine();
        }
    }
}
