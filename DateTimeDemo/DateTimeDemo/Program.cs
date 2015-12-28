using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime1 = new DateTime(2015, 12, 28, 15, 0, 0, 0);
            DateTime dateTime2 = new DateTime(2015, 12, 28, 16, 1, 13, 0);

            TimeSpan ts1 = new TimeSpan(dateTime1.Ticks);
            TimeSpan ts2 = new TimeSpan(dateTime2.Ticks);

            TimeSpan ts = ts2.Subtract(ts1).Duration();

            int nHours = ts.Hours;
            int nMinutes = ts.Minutes;
            int nSeconds = ts.Seconds;

            Console.WriteLine(ts);

            Console.WriteLine("here");
        }
    }
}
