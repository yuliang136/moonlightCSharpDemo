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

            // TimeSpan用法有问题.

            //TimeSpan ts1 = new TimeSpan(dateTime1.Ticks);
            //TimeSpan ts2 = new TimeSpan(dateTime2.Ticks);

            //TimeSpan ts = ts2.Subtract(ts1).Duration();

            //int nHours = ts.Hours;
            //int nMinutes = ts.Minutes;
            //int nSeconds = ts.Seconds;

            //Console.WriteLine(ts);



            Console.WriteLine("here");
        }

        public static string GetFormatTimeShow(TimeSpan ts)
        {
            string strRtn = string.Empty;

            strRtn = string.Format("{0}:{1}:{2}",
                                    ts.Hours.ToString().PadLeft(2, '0'),
                                    ts.Minutes.ToString().PadLeft(2, '0'),
                                    ts.Seconds.ToString().PadLeft(2, '0'));

            return strRtn;
        }

        /// <summary>
        /// Double时间转为C#里DateTime时间.
        /// </summary>
        /// <param name="dTime"></param>
        /// <returns></returns>
        public System.DateTime ConvertIntDateTime(double dTime)
        {
            System.DateTime time = System.DateTime.MinValue;
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            time = startTime.AddSeconds(dTime);

            //MgrCommon.MyDebugLog(time.ToString());

            return time;
        }

        /// <summary>
        /// C#里DateTime时间转为Double时间.
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public double ConvertDateTimeInt(System.DateTime time)
        {
            double dResult = 0.0;
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            dResult = (time - startTime).TotalSeconds;
            return dResult;
        }

        /// <summary>
        /// 传入ts 获得格式化字符串.
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public string GetFormatTimeShow(int nTime)
        {
            string strRtn = string.Empty;

            //strRtn = string.Format("{0}:{1}:{2}",
            //                        ts.Hours.ToString().PadLeft(2, '0'),
            //                        ts.Minutes.ToString().PadLeft(2, '0'),
            //                        ts.Seconds.ToString().PadLeft(2, '0'));

            //strRtn = string.Format("{0}:{1}:{2}", ts.Hours, ts.Minutes, ts.Seconds);

            int nHour = 0;
            int nMinute = 0;
            int nSecond = 0;

            int nLeftTime = nTime;

            // Hour.
            nHour = nLeftTime / 3600;
            nLeftTime = nLeftTime - nHour * 3600;

            // Minute.
            nMinute = nLeftTime / 60;
            nLeftTime = nLeftTime - nMinute * 60;

            // Second.
            nSecond = nLeftTime;

            strRtn = string.Format("{0}:{1}:{2}",
                                    nHour.ToString().PadLeft(2, '0'),
                                    nMinute.ToString().PadLeft(2, '0'),
                                    nSecond.ToString().PadLeft(2, '0'));


            return strRtn;
        }
    }
}
