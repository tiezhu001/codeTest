using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _02_Others
{
    public class Delegate
    {
        public static void Input()
        {
            Func<int, int, string> func = (x, y) => (x * y).ToString();
            Console.WriteLine(func(5, 10));
        }
    }
}
