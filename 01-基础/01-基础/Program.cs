using _01_基础.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01_基础
{
    class Program
    {
        static void Main(string[] args)
        {


            //1.普通列表是对象的排序
            //ArrayList products = Product.GetProducts();
            //products.Sort(new ProductCompare());

            //2.泛型列表里边是对象的排序
            //List<Product> products = Product.GetListProducts();
            //products.Sort(new FanxingListComprer());

            //foreach (var item in products)
            //{
            //    Console.WriteLine(item);
            //}

            //3.普通列表里边是字符串排序
            //List<string> nameList = new List<string>() { "f", "b", "e" };
            ////nameList.Sort();
            //foreach (var item in nameList.Skip(1).OrderBy(c=>c))
            //{
            //    Console.WriteLine(item);
            //}

            // 4.找出大于9的数
            //List<int> nameList2 = new List<int>() { 9, 10, 11 };
            //Predicate<int> test = delegate (int name) { return name > 9; };
            //List<int> matchs = nameList2.FindAll(test);
            //Action<int> print = Console.WriteLine;
            //matchs.ForEach(print);

            // 5.循环指定的列表，并把每一个元素添加到新的列表
            //List<int> result = new List<int>();
            //Action<int> printTwo = result.Add;
            //matchs.ForEach(printTwo);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            // 6.Linq查询
            // from in product 相当于取出列表中的每一项内容,也就是p相当于每一项产品
            // 我们定义的产品或者供货商 字段都是readonly所以无法访问到对应的字段,所以通过属性访问到字段的值
            // 
<<<<<<< HEAD
=======

            // 6.1 linq to list 
>>>>>>> 本地未提交的内容
            List<Product> product = Product.GetListProducts();
            List<Suppliers> suppliers = Suppliers.GetSuppliersList();

            var selectResult = from p in product
                               join s in suppliers
                                on p.id equals s.ID
                               where p.Price > 66m
                               orderby p.ID
                               //select new { name = s.Name, id = p.ID, price = p.Price };
                               select p.name;

            foreach (var item in selectResult)
            {
                Console.WriteLine(item);
            }










<<<<<<< HEAD
           Console.ReadKey();
=======

            Console.ReadKey();
>>>>>>> 本地未提交的内容
        }
    }




}
