using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LINQ.Entities
{
    internal class Product
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        //public Category Category { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }




        /*
        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Category.Name
                + ", "
                + Category.Tier;
        }*/
    }
}
