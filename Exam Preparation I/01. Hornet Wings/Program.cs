using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double travelledDistance = (wingFlaps / 1000) * distance;
           
            double time = wingFlaps / 100;
            double rests = (wingFlaps / endurance) * 5;
            Console.WriteLine("{0:f2} m.", travelledDistance);
            Console.WriteLine("{0} s.", time + rests);
        }
    }
}
