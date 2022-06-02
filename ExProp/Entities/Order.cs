using System;
using System.Collections.Generic;
using System.Text;
using ExProp.Entities;
using ExProp.Entities.Enums;


namespace ExProp.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total(int quantity, double price)
        {
            double sum = 0;
            foreach (OrderItem it in Items)
            {
                sum += it.SubTotal(quantity, price);
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order items:");
            
            foreach (OrderItem o in Items)
            {
                sb.AppendLine(o.Products);
            }
            return sb.ToString();
        }
    }
}
