using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Homework04_2
{
    public delegate void TickHandler(object sender);
    public delegate void AlarmHandler(object sender);
    class Clock
    {
        public event TickHandler OnTick;
        public event AlarmHandler OnAlarm;

        public int Time { set; get; }
        public void Tick()
        {
            while (Time > 0)
            {
                Console.WriteLine(DateTime.Now.ToString());
                OnTick(this);
                Time--;
                Thread.Sleep(1000);
            }
        }
        public void Alarm()
        {
            Console.WriteLine("Alarm:" + DateTime.Now.ToString());
            OnAlarm(this);
        }
    }
}
