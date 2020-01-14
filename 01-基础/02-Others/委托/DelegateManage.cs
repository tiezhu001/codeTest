using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Others.委托
{
    /// <summary>
    /// 委托通常和指代的方法不在同一个类中
    /// </summary>
   public class DelegateManage
    {
        public SayHello sayHelloDelegate;

        // 调用此方法,必须需要传递一个委托对象
        public void AllSayHello(string name, SayHello sayHelloDelegate)
        {
            this.sayHelloDelegate(name);
        }

        public void AllSayHello2(string name)
        {
            sayHelloDelegate?.Invoke(name);

            // 上述是正规写法
            //if (sayHelloDelegate != null)
            //{
            //    sayHelloDelegate(name);
            //}

        }
    }
}
