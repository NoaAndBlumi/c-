using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Bll
{

    public class Timer
    {

        static void main(string[] args)
        {
           // TaskScheduler t;
            MotherBll.CheckTimeOfBirth();
        }

        public static implicit operator Timer(System.Timers.Timer v)
        {
            throw new NotImplementedException();
        }

        internal int Interval;
        internal Action<object, ElapsedEventArgs> Elapsed;
        internal bool Enabled;
        // public static void


    }
}
