using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Shellbound
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, HashSet<int>>();
            string[] input = Console.ReadLine().Split(' ');
            while (input[0] != "Aggregate")
            {
                string region = input[0];
                int shellSize = int.Parse(input[1]);

                if (!data.ContainsKey(region))
                {
                    data.Add(region, new HashSet<int>());
                }

                data[region].Add(shellSize);

                input = Console.ReadLine().Split(' ');
            }

            foreach (var record in data)
            {
                string outputKey = record.Key;
                HashSet<int> outputValues = record.Value;

                int average = (int)outputValues.Average();
                int sum = (int)outputValues.Sum();
                int giantShellSize = sum - average;

                Console.WriteLine("{0} -> {1} ({2})",
                    outputKey,
                    string.Join(", ", outputValues),
                    giantShellSize);
            }
        }
    }
}
