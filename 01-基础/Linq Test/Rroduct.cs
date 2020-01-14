using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Test
{
    class Rroduct
    {
        readonly string name;
        readonly decimal price;

        public string Name { get { return name; } }
        public decimal Price { get { return price; } }

        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }
        public static ArrayList GetProducts()
        {
            return new ArrayList
            {
                new Product (name:"abc",price:99m ),
                new Product(name:"efg",price:66m),
                new Product(name:"aaa",price:66m),

            };
        }

        public static List<Product> GetListProducts()
        {
            return new List<Product>
            {
                new Product (name:"abc",price:99m ),
                new Product(name:"efg",price:66m),
                new Product(name:"aaa",price:66m),

            };
        }

        public override string ToString()
        {
            return string.Format("{0},{1}", name, price);
        }
    }
}
}
