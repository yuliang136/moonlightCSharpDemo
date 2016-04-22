using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetCurrentTimeString
{
    class Program
    {
        static void Main(string[] args)
        {
            String strTime = DateTime.Now.ToString("yyyyMMdd-hhmmss");

            Console.WriteLine(strTime);
        }
    }
}
