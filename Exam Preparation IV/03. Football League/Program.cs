using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Football_League
{
    class Team
    {
        public int Points { get; set; }
        public int Goals { get; set; }

        public Team(int points, int goals)
        {
            this.Points = points;
            this.Goals = goals;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Team>();

            string key = Console.ReadLine();
            string escapedKey = Regex.Escape(key);
            string pattern =
                string.Format(@"(?<={0})(?<teamA>[a-zA-Z]*)(?={0}).*(?<={0})(?<teamB>[a-zA-Z]*)(?={0})[^ ]+ (?<scoreA>\d+):(?<scoreB>\d+)", escapedKey);

            Regex gameRegex = new Regex(pattern);

            string input;

            while ((input = Console.ReadLine()) != "final")
            {
                Match match = gameRegex.Match(input);

                string teamA = ReverseString(match.Groups["teamA"].Value).ToUpper();
                string teamB = ReverseString(match.Groups["teamB"].Value).ToUpper();
                int scoreA = int.Parse(match.Groups["scoreA"].Value);
                int scoreB = int.Parse(match.Groups["scoreB"].Value);

                if (!data.ContainsKey(teamA))
                {
                    data.Add(teamA, new Team(0, 0));
                }

                if (!data.ContainsKey(teamB))
                {
                    data.Add(teamB, new Team(0, 0));
                }

                data[teamA].Goals += scoreA;
                data[teamB].Goals += scoreB;

                if (scoreA > scoreB)
                {
                    data[teamA].Points += 3;
                }
                else if (scoreA < scoreB)
                {
                    data[teamB].Points += 3;
                }
                else if (scoreA == scoreB)
                {
                    data[teamA].Points += 1;
                    data[teamB].Points += 1;
                }

            }

            var standings = data.OrderByDescending(s => s.Value.Points).ThenBy(s => s.Key);
            var topThreebyGoals = data.OrderByDescending(s => s.Value.Goals).ThenBy(s => s.Key).Take(3);

            int position = 1;
            Console.WriteLine("League standings:");
            foreach (var teamData in standings)
            {
                string teamName = teamData.Key;
                Team team = teamData.Value;

                Console.WriteLine("{0}. {1} {2}", position, teamName, team.Points);
                position++;
            }
            Console.WriteLine("Top 3 scored goals:");
            foreach (var teamData in topThreebyGoals)
            {
                string teamName = teamData.Key;
                Team team = teamData.Value;
                Console.WriteLine("- {0} -> {1}", teamName, team.Goals);
            }
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
