using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Others.委托
{
    public delegate void SayHello(string name);

    public class SimpleDelegate
    {
        public void ChineseSayHello(string name)
        {
            Console.WriteLine($"{name},你好");
        }

        public void EnglishSayHello(string name)
        {
            Console.WriteLine($"{name},hello");
        }

        public void AllSayHello(string name, SayHello delegate1)
        {
            delegate1(name);
        }
    }
}
