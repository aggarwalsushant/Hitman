using System;
using System.Timers;

namespace Hitman
{
    interface ICountdownTimer
    {
        bool IsExpired { get; }

        bool CreateTimer(int seconds = 15);

        void Start();

        void Stop();

        void Reset();
    }

    internal class CountdownTimer: ICountdownTimer
    {
        public bool IsExpired { get; private set; }
        private Timer timer;

        public CountdownTimer(int seconds)
        {
            CreateTimer(seconds);
        }

        public bool CreateTimer(int seconds = 15)
        {
            timer = new Timer(seconds * 1000);
            IsExpired = false;
            timer.Elapsed += Timer_Tick;
            return true;
        }

        public void Start() => timer.Start();

        public void Stop()
        {
            timer.Stop();
        }

        void Timer_Tick(object sender, EventArgs e)
            => IsExpired = true;

        public void Reset()
        {
            Stop();
            IsExpired = false;
        }
    }
}
