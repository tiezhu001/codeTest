using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_基础
{
    // 没有引入泛型，比较数组中以什么排序
    class ArrayListCompaer
    {
    }

    public class ProductCompare : IComparer
    {
        public int Compare(object x, object y)
        {
            Product first = (Product)x;
            Product second = (Product)y;
            return first.Name.CompareTo(second.Name);
        }
    }
}
