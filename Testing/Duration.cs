using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    public class Duration
    {
        public Duration(long miliseconds)
        {
            this.miliseconds = miliseconds;
            TotalSeconds(this);
        }

        public Duration(long hours, long minutes, long seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
            TotalSeconds(this);
        }
        public long miliseconds { get; set; }
        public long seconds { get; set; }
        public long minutes { get; set; }
        public long hours { get; set; }
        public long days { get; set; }
        public long years { get; set; }
        //public long totalSeconds { get; set; }

        private long _totalSeconds;

        public long totalSeconds
        {
            get { return _totalSeconds; }
            set { _totalSeconds = value; }
        }

        public static void TotalSeconds(Duration duration)
        {
            duration.totalSeconds = duration.years * (long)3.154e+7 + duration.days * 86400 + duration.hours * 3600 + duration.minutes * 60 + duration.seconds;
            
            if (duration.miliseconds > 0)
            {
                duration.totalSeconds += 1000 / duration.miliseconds;
            }
        }


        public long Add(Duration a)
        {
            //TotalSeconds(a);
            return this.totalSeconds += a.totalSeconds;
        }

        public long Sub(Duration a)
        {
            return this.totalSeconds -= a.totalSeconds;
        }

        public long Mul(int a)
        {
            return this.totalSeconds *= a;
        }
    }
}
