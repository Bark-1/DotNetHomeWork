using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SetAlarmTime(5);
            person.StartClock();
            
            while (true) { };
        }

    }
    public delegate void AlarmHandler(object sender, int args);

    public class Clock
    {
        public int AlarmTime { set; get; }
        private int CurrentTime = 0;
        private System.Timers.Timer timer;
        public event AlarmHandler OnAlarm;
        public Clock()
        {
            timer = new System.Timers.Timer(1000);
            timer.AutoReset = true;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(Tick);
            timer.Enabled = true;
        }
        public void StartTimer()
        {
            timer.Start();
        }
        //Tick不用person订阅。是clock内部事件。当person调用StartClock时开始。当时间到时触发Alarm
        public void Tick(object sender,System.Timers.ElapsedEventArgs e)
        {
            CurrentTime++;
            Console.WriteLine($"Tick! CurrentTime:{CurrentTime}");
            if (CurrentTime == AlarmTime) { OnAlarm(this, CurrentTime); }
        }
    }

    public class Person
    {
        public Clock clock;
        public Person()
        {
            clock = new Clock();
            clock.OnAlarm += ClockOnAlarm;
        }
        public void SetAlarmTime(int time)
        {
            clock.AlarmTime = time;
        }
        public void StartClock()
        {
            clock.StartTimer();
        }
        void ClockOnAlarm(object sender, int time)
        {
            Console.WriteLine($"Alarm! CurrentTime:{time}");
        }
    }
}
