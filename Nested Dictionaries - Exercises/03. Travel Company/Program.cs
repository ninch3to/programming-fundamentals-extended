using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Travel_Company
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, int>>();
            string[] inputTokens = Console.ReadLine().Split(':');

            while (inputTokens[0] != "ready")
            {
                string city = inputTokens[0];
                string[] vehicles = inputTokens[1].Split(',');

                foreach (string vehicle in vehicles)
                {
                    string[] vehicleData = vehicle.Split('-');
                    string vehicleType = vehicleData[0];
                    int vehicleCapacity = int.Parse(vehicleData[1]);

                    if (!data.ContainsKey(city))
                    {
                        data.Add(city, new Dictionary<string, int>());
                    }
                    data[city][vehicleType] = vehicleCapacity;
                }
                inputTokens = Console.ReadLine().Split(':');
            }

            string[] groupData = Console.ReadLine().Split(' ');

            while (groupData[0] != "travel")
            {
                string city = groupData[0];
                int tourists = int.Parse(groupData[1]);
                Dictionary<string, int> busesData = data[city];
                int combinedSeats = busesData.Select(b => b.Value).Sum();

                if (combinedSeats >= tourists)
                {
                    Console.WriteLine("{0} -> all {1} accommodated",
                    city,
                    tourists);
                }
                else
                {
                    Console.WriteLine("{0} -> all except {1} accommodated",
                        city,
                        tourists - combinedSeats);
                }
                groupData = Console.ReadLine().Split(' ');
            }

            
        }
    }
}
