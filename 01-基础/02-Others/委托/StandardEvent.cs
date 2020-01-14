using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Others.委托
{

    class StandardEvent
    {
        public int temperature;
        public string type = "Good牌";
        public string name = "Mike";

        public delegate void BoiledHandler(object sender, BoildEventArgs e);

        public event BoiledHandler BoilEvent;

        public void BoilWater()
        {
            for (int i = 0; i < 100; i++)
            {
                temperature = i;
            }

            if (temperature >= 96)
            {
                BoildEventArgs e= new BoildEventArgs(temperature);
                BoilEvent?.Invoke(this,e);
            }
        }

    }

    public class BoildEventArgs : EventArgs
    {
        public readonly int temperature;

        public BoildEventArgs(int temperature)
        {
            this.temperature = temperature;
        }
    }

    /// <summary>
    /// 警报类
    /// </summary>
    public class Alerm2
    {
        public void MakeAlert(object sender, BoildEventArgs e)
        {
            StandardEvent heater = (StandardEvent)sender;
            Console.WriteLine($"滴滴滴滴,温度超过{heater.temperature}");
            Console.WriteLine("{0}，{1}", heater.type, heater.name);
        }
    }

    public class Display2
    {
        public static void DisplayTemperature(object sender, BoildEventArgs e)
        {
            StandardEvent heater = (StandardEvent)sender;
            Console.WriteLine($"温度{heater.temperature}");
            Console.WriteLine("{0}，{1}", heater.type, heater.name);
        }
    }
}
/*
 在此方法实现中,实现了简单的观察者模式，并且使用规范的事件声明,对于一个任意的委托和它委托代表的方法，可能有多种多样的声明方式,
 比如参数有很多种,返回值有很多种,这样委托声明起来就会很麻烦,所以.net定义了一项委托和事件声明的规范。
 对于本例:Heater是监视对象，因为此对象里边的temperature为另两个类所需要的，Alerm和Diplay就是监视着，他们监视Heater,只要Heater对象发生
 变化，Alerm和Display也要发生相应的变化，也就是事件。如果想获得Heater对象的属性和字段，我们直接可以把Heater对象的引用传递给Alerm的方法。
 所以在使用的时候，就可以直接访问它内部的属性。
 
 
 */