using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExercise.Entities
{
    class Product
    {
        public string NameProduct { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string nameProduct, double price)
        {
            NameProduct = nameProduct;
            Price = price;
        }

        public override string ToString()
        {
            return $"{NameProduct}, {Price},";
        }
    }
}
