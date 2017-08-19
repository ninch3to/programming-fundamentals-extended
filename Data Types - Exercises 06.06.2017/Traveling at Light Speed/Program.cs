using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveling_at_Light_Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal kmsForLightYear = 9450000000000;
            decimal kmsPerSecond = 300000;
            decimal lightYears = decimal.Parse(Console.ReadLine());

            decimal secondsTotal = (lightYears * kmsForLightYear) / kmsPerSecond;
            int minutes = (int)secondsTotal / 60;
            secondsTotal %= 60;
            int hours = (minutes / 60);
            minutes %= 60;
            int days = hours / 24;
            hours %= 24;
            int weeks = days / 7;
            days %= 7;
            Console.WriteLine("{0} weeks", weeks);
            Console.WriteLine("{0} days", days);
            Console.WriteLine("{0} hours", hours);
            Console.WriteLine("{0} minutes", minutes);
            Console.WriteLine("{0} seconds", (int)secondsTotal);
        }
    }
}
