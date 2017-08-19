using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace camping
{
    class Program
    {
        static void Main(string[] args)
        {
            var campingData = new Dictionary<string, Dictionary<string, int>>();

            string[] inputTokens = Console.ReadLine().Split(' ').ToArray();

            while (inputTokens[0] != "end")
            {
                string nameOfPerson = inputTokens[0];
                string camperModel = inputTokens[1];
                int nights = int.Parse(inputTokens[2]);

                if (!campingData.ContainsKey(nameOfPerson))
                {
                    campingData.Add(nameOfPerson, new Dictionary<string, int>());
                }
                campingData[nameOfPerson][camperModel] = nights;
                
                inputTokens = Console.ReadLine().Split(' ').ToArray();
            }

            var orderedCampingData = campingData
                .OrderBy(d => d.Key.Length)
                .OrderByDescending(d => d.Value.Count());

            foreach (var camperdata in orderedCampingData)
            {
                string person = camperdata.Key;
                var personsData = camperdata.Value;

                int sum = personsData.Sum(d => d.Value);

                Console.WriteLine(person + ": " + personsData.Count);

                foreach (var personData in personsData)
                {
                    string innerKey = personData.Key;
                    int innerValue = personData.Value;

                    Console.WriteLine("***{0}", innerKey);
                }
                Console.WriteLine("Total stay: {0} nights", sum);
            }
        }
    }
}
