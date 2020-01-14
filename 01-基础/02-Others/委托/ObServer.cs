using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Others.委托
{

    /// <summary>
    /// 通过委托和时间，实现观察者模式
    /// </summary>
    class ObServer
    {
    }


    /// <summary>
    /// 热水器类
    /// </summary>
    public class Heater
    {
        public int Temperature { get; set; }

        public delegate void BoilWaterHandler(int temperature);

        public event BoilWaterHandler boilWaterEnvter;

        public void BoilWater()
        {
            for (int i = 0; i < 100; i++)
            {
                Temperature = i;
            }

            if (Temperature >= 98)
            {
                boilWaterEnvter?.Invoke(Temperature);
            }
        }

      
    }

    /// <summary>
    /// 警报类
    /// </summary>
    public class Alerm
    {
        public void MakeAlert(int temperature)
        {
            Console.WriteLine($"滴滴滴滴,温度超过{temperature}");
        }
    }

    public class Display
    {
        public static void DisplayTemperature(int temperature)
        {
            Console.WriteLine($"温度已经{temperature}");
        }
    }

}
