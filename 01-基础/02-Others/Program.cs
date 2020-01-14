using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Others.委托;

namespace _02_Others
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.委托
            //Delegate.Input();

            // 2.SimpleDelegate
            //SimpleDelegate simpleDelegate = new SimpleDelegate();
            //simpleDelegate.AllSayHello("小王", simpleDelegate.ChineseSayHello);
            //simpleDelegate.AllSayHello("Mike", simpleDelegate.EnglishSayHello);

            // 3.将方法传递给委托
            //SayHello delegate2;
            //SimpleDelegate simpleDelegate = new SimpleDelegate();
            //SayHello delegate1;
            //delegate1 = simpleDelegate.ChineseSayHello;
            //delegate2 = simpleDelegate.EnglishSayHello;
            //simpleDelegate.AllSayHello("小王",delegate1);
            //simpleDelegate.AllSayHello("Mike",delegate2);

            // 4.一个委托绑定多个方法
            //SayHello delegate1;
            //SimpleDelegate simpleClass = new SimpleDelegate();
            //delegate1 = simpleClass.ChineseSayHello;
            //delegate1 += simpleClass.EnglishSayHello;
            //simpleClass.AllSayHello("Mike",delegate1);

            // 5.通过委托直接调用，绕过sayHello方法
            //SayHello delegate1;
            //SimpleDelegate simpleClass = new SimpleDelegate();
            //delegate1 = simpleClass.ChineseSayHello;
            //delegate1 += simpleClass.EnglishSayHello;
            //delegate1("Mike");

            /* 6.因为委托也是一种类型，所以为了符合面向对象的设计，通常也把委托对象，进行封装，也就是委托对象
             都在一个delegate manage,在如下方法中，虽然对sayHelloDelegate绑定了方法，但是在调用AllSayHello方法的时候
             仍然需要传入一个委托对象
             */
            //DelegateManage delegateManage = new DelegateManage();
            //SimpleDelegate simpleClass = new SimpleDelegate();
            //delegateManage.sayHelloDelegate = simpleClass.ChineseSayHello;
            //delegateManage.sayHelloDelegate += simpleClass.EnglishSayHello;
            //delegateManage.AllSayHello("Mike",delegateManage.sayHelloDelegate);

            // 7.方法6的改进
            //DelegateManage delegateManage = new DelegateManage();
            //SimpleDelegate simpleClass = new SimpleDelegate();
            //delegateManage.sayHelloDelegate = simpleClass.ChineseSayHello;
            //delegateManage.sayHelloDelegate += simpleClass.EnglishSayHello;
            //delegateManage.AllSayHello2("Mike");

            // 8.委托和事件实现简单的观察者模式
            //Heater heater = new Heater();
            //Alerm alerm = new Alerm();
            //heater.boilWaterEnvter += alerm.MakeAlert;
            //heater.boilWaterEnvter += Display.DisplayTemperature;
            //heater.BoilWater();

            // 9.标准的事件使用方式
            StandardEvent standardEvent = new StandardEvent();
            Alerm2 alerm2 = new Alerm2();
            standardEvent.BoilEvent += alerm2.MakeAlert;
            standardEvent.BoilEvent += Display2.DisplayTemperature;
            standardEvent.BoilWater();





            Console.ReadKey();

        }


        public class VarType
        {

        }

    }
}
