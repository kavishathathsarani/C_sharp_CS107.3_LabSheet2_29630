using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureTracker tracker = new TemperatureTracker();
            tracker.DailyTemperature();
            tracker.Report();

            

            Console.ReadLine();
        }
    }
}
