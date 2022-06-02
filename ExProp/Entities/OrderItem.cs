using System;
using System.Collections.Generic;

namespace ExProp.Entities
{
    class OrderItem
    {
        int Quantity { get; set; }
        double Price { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public double SubTotal(int quantity, double price)
        {
            return quantity * price;
        }
    }
}
