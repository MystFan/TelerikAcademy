using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _08.Events
{
    public class TimerArguments : EventArgs
    {
        public int Seconds { get; set; }
    }
    public class Timer
    {
        public event EventHandler<TimerArguments> Timed;

        public void RunTimer(int seconds)
        {
            while (seconds > 0)
            {
                Console.WriteLine(seconds);
                Thread.Sleep(1000);
                OnTimer(seconds);
                seconds--;
            }
            OnTimer(seconds);
        }
        protected virtual void OnTimer(int seconds)
        {
            if (Timed != null)
            {
                Timed(this, new TimerArguments() { Seconds = seconds });
            }
        }
    }
}
