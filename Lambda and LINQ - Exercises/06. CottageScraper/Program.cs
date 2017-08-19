using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CottageScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new List<KeyValuePair<string, int>>();
            string input = Console.ReadLine();

            while (input != "chop chop")
            {
                string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string woodType = tokens[0];
                int woodHeight = int.Parse(tokens[1]);
                data.Add(new KeyValuePair<string, int>(woodType, woodHeight));

                input = Console.ReadLine();
            }

            string wantedType = Console.ReadLine();
            int minHeight = int.Parse(Console.ReadLine());
            double pricePerMeter = Math.Round(data.Average(d => d.Value), 2);

            double usedLogsValue = data.Where(d => d.Key == wantedType && d.Value >= minHeight).Sum(d => d.Value);
            double unusedLogsValue = data.Where(d => d.Key != wantedType || d.Value < minHeight).Sum(d => d.Value);

            usedLogsValue = Math.Round(usedLogsValue * pricePerMeter, 2);
            unusedLogsValue = Math.Round(unusedLogsValue * pricePerMeter * 0.25, 2);

            Console.WriteLine("Price per meter: ${0:f2}", pricePerMeter);
            Console.WriteLine("Used logs price: ${0:f2}", usedLogsValue);
            Console.WriteLine("Unused logs price: ${0:f2}", unusedLogsValue);
            Console.WriteLine("CottageScraper subtotal: ${0:f2}", Math.Round(unusedLogsValue + usedLogsValue, 2));
        }
    }
}
