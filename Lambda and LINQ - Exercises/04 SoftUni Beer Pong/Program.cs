using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SoftUni_Beer_Pong
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            
            while (input != "stop the game")
            {
                string[] inputTokens = input.Split('|');
                string teamName = inputTokens[1];
                string playerName = inputTokens[0];
                int playerScore = int.Parse(inputTokens[2]);
                
                if (!data.ContainsKey(teamName))
                {
                    data.Add(teamName, new Dictionary<string, int>());
                }

                if (data[teamName].Count() < 3)
                {
                    data[teamName][playerName] = playerScore;
                }

                input = Console.ReadLine();
            }
            var orderedData = data
              .Where(r => r.Value.Count == 3)
              .OrderByDescending(r => r.Value.Sum(playerRecord => playerRecord.Value));

            int teamRanking = 1;
            foreach (var record in orderedData)
            {
                string key = record.Key;
                var innerRecords = record.Value.OrderByDescending(d => d.Value);

                Console.WriteLine("{0}. {1}; Players:", teamRanking, key);

                foreach (var innerRecord in innerRecords)
                {
                    string innerKey = innerRecord.Key;
                    int innerValue = innerRecord.Value;

                    Console.WriteLine("###{0}: {1}", innerRecord.Key, innerRecord.Value);
                }
                teamRanking++;
            }

        }
    }
}
