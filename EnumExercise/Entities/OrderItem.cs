using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EnumExercise.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Products { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product products)
        {
            Quantity = quantity;
            Price = price;
            Products = products;
        }

        public double SubTotal()
        {
            return (Quantity * Price);
        }

        public override string ToString()
        {
            return $"{Products} Quantity: {Quantity}, Subtotal: ${SubTotal().ToString("F2",CultureInfo.InvariantCulture)}";
        }


    }
}
