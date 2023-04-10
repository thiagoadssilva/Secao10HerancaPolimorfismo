using ExercicioProposto01.Entities.Enums;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto01.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public StatusProduct Status { get; set; }
        public TypeProduct Type { get; set; }

        public Product() { }

        public Product(string name, double price, StatusProduct statusProduct, TypeProduct type)
        {
            Name = name;
            Price = price;
            Status = statusProduct;
            Type = type;
        }

        public virtual string PriceTag()
        {
            return Name + "$ " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
