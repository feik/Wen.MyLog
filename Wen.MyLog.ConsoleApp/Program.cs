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

            var watch = new Stopwatch();
            watch.Start();

            for (var i = 0; i < num; i++)
            {
                MyLogger.Debug("Debug"); //他的
            }
            var t1 = watch.ElapsedMilliseconds;

            Console.WriteLine(t1);

            Console.Read();
        }
    }
}
