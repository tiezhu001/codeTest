using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_基础.Linq
{
    /// <summary>
    /// 供货商类
    /// </summary>
    class Suppliers
    {
        readonly string name;
        readonly int id;

        public string Name { get { return name; } }
        public int ID { get { return id; } }

        public Suppliers(string name,int id)
        {
            this.name = name;
            this.id = id;
        }

        public static List<Suppliers> GetSuppliersList()
        {
            return new List<Suppliers>()
            {
                new Suppliers("供货商1",1),
                new Suppliers("供货商2",2),
                new Suppliers("供货商4",4)

            };
        }

        public override string ToString()
        {
            return string.Format("{0},{1}", name, id);
        }
    }
}
