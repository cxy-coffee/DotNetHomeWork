using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Homework04_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            clock.OnTick += Program.Clk_OnTick;
            clock.OnAlarm += Program.Clk_OnAlarm;
            clock.Time = 5;
            clock.Tick();
            clock.Alarm();
        }

        static void Clk_OnTick(object sender)
        {
            Console.WriteLine("Tick一下。");
        }
        static void Clk_OnAlarm(object sender)
        {
            Console.WriteLine("Alarm一下。");
        }
    }
}
