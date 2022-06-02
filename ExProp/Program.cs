using System;
using System.Globalization;
using ExProp.Entities;
using ExProp.Entities.Enums;

namespace ExProp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order?: ");
            int n = int.Parse(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, new Client(name, email, birthDate));

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} data:");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product price: ");
                double prodPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(prodName, prodPrice);
                OrderItem items = new OrderItem(quantity, prodPrice);
                order.AddItem(items);
            }

            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine("Order moment: " + order.Moment);
            Console.WriteLine("Order status: " + order.Status);
            Console.WriteLine(order.Client.Name + " (" + order.Client.BirthDate.Date + ") - " + order.Client.Email);
            Console.WriteLine(order);



        }
    }
}
