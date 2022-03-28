﻿using System.Globalization;

namespace PointSale.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public OrderItem()
        {

        }
        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: " 
                + Quantity 
                + ", SubTotal: $" + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
