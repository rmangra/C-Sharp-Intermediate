using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = StopWatch.Instance;
            for (var i = 0; i < 2; i++)
            {
                stopwatch.Start();
                System.Threading.Thread.Sleep(1000);
                stopwatch.Stop();
                Console.WriteLine("Duration: " + stopwatch.GetInterval());
                Console.WriteLine("Press Enter to run the stopwatch one more time.");
                Console.ReadLine();
            }
        }
    }
}
