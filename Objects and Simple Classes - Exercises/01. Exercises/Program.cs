using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Exercise> exercises = new List<Exercise>();

            string input = Console.ReadLine();

            while (input != "go go go")
            {
                string[] inputTokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string topic = inputTokens[0];
                string courseName = inputTokens[1];
                string judgeContestLink = inputTokens[2];
                List<string> problems = inputTokens[3]
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                exercises.Add(new Exercise(topic, courseName, judgeContestLink, problems));

                input = Console.ReadLine();
            }

            foreach (Exercise exercise in exercises)
            {
                Console.WriteLine("Exercises: {0}", exercise.Topic);
                Console.WriteLine("Problems for exercises and homework for the \"{0}\" course @ SoftUni.", exercise.CourseName);
                Console.WriteLine("Check your solutions here: {0}", exercise.JudgeContestLink);
                int count = 1;

                foreach (var problem in exercise.Problems)
                {
                    Console.WriteLine("{0}. {1}", count, problem);
                    count++;
                }
            }
        }
    }

    class Exercise
    {
        public string Topic { get; set; }
        public string CourseName { get; set; }
        public string JudgeContestLink { get; set; }
        public List<string> Problems { get; set; }

        public Exercise(string topic, string courseName, string judgeContestLink, List<string> problems)
        {
            this.Topic = topic;
            this.CourseName = courseName;
            this.JudgeContestLink = judgeContestLink;
            this.Problems = problems;
        }
    }
}
