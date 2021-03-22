using System;

namespace Alarm
{

    class Clock
    {
        public delegate void AlarmEventHandler(object sender, EventArgs e);

        public event AlarmEventHandler Alarm;
        public event AlarmEventHandler Tick;

        public DateTime now = new DateTime(2020, 12, 31, 23, 59, 50);
        public DateTime timing = new DateTime(2021, 1, 1, 0, 0, 0);

        public void OnAlarm()
        {
            if (this.Alarm != null)
            {
                this.Alarm(this, new EventArgs());
            }
            else
            {
                throw new ArgumentException("没有事件被注册");
            }
        }

        public void OnTick()
        {
            if (this.Tick != null)
            {
                this.Tick(this, new EventArgs());
            }
            else
            {
                throw new ArgumentException("没有事件被注册");
            }
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            Clock clock = new Clock();
            clock.Alarm += new Clock.AlarmEventHandler(Alarm);
            clock.Tick += new Clock.AlarmEventHandler(Tick);

            while (clock.now < clock.timing)
            {
                clock.OnTick();
                System.Threading.Thread.Sleep(1000);
                clock.now = clock.now.AddSeconds(1);
            }

            clock.OnAlarm();
            Console.ReadKey();
        }

        public static void Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Tick....");
        }

        public static void Alarm(object sender, EventArgs e)
        {
            Console.WriteLine("Alarm!!!!");
        }
    }


}