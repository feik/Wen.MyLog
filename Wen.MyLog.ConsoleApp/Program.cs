using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wen.MyLog.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const int num = 500000; //50W
            const string msg = "test";

            var watch = new Stopwatch();
            watch.Start();

            for (var i = 0; i < num; i++)
            {
                MyLogger.Debug(msg);
            }

            var t1 = watch.ElapsedMilliseconds;

            Console.WriteLine($"t1: {t1}");

            for (var i = 0; i < num; i++)
            {
                MyLogger.Info(i.ToString());
            }

            var t2 = watch.ElapsedMilliseconds;
            Console.WriteLine($"t2 - t1: {t2 - t1}");
            Console.Read();
        }
    }
}
