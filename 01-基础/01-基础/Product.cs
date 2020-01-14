using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_基础
{
    class Product
    {
        public string name;
        public decimal price;
        public int id;

        public string Name { get { return name; } }
        public decimal Price { get { return price; } }
        public int ID { get { return id; } }

        public Product(string name, decimal price,Nullable<int> id=0)
        {
            this.name = name;
            this.price = price;
            this.id = id.Value;
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
                new Product (name:"abc",price:99m ,id:1),
                new Product(name:"efg",price:66m,id:2),
                new Product(name:"aaa",price:66m,id:3),

            };
        }

        public override string ToString()
        {
            return string.Format("{0},{1}", name, price);
        }
    }
}