using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class TemperatureTracker
    {
        public double[] Temperature = new double[7];
        public void DailyTemperature()
        {
            for (int i = 0; i < 7; i++)

            {
                Console.Write($"Enter temperature for day {i + 1}: ");
                Temperature[i] = double.Parse(Console.ReadLine());
            }
        }

        public void Report()
        {
            Console.WriteLine("Weekly Temperature Report ");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Day {i + 1}: {Temperature[i]}°C");
            }
        }
    }
}
