using System;

namespace ExProp.Entities
{
    class Product
    {
        string Name { get; set; }
        double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
