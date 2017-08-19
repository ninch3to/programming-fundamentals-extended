using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace _02.Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> messages = new List<string>();
            List<string> broadcasts = new List<string>();
            string[] input = Console.ReadLine().Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);
            
            while (input[0] != "Hornet is Green")
            {
                if (input.Length != 2)
                {
                    input = Console.ReadLine().Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }
                string leftQuery = input[0];
                string rightQuery = input[1];

                if (leftQuery.All(char.IsDigit) && rightQuery.All(char.IsLetterOrDigit))
                {
                    string reversed = new string(leftQuery.ToCharArray().Reverse().ToArray());
                    messages.Add($"{reversed} -> {rightQuery}");
                }
                else if (leftQuery.All(c => !char.IsDigit(c)) && rightQuery.All(char.IsLetterOrDigit))
                {
                    string reversedCases = ReverseCases(rightQuery);
                    broadcasts.Add($"{reversedCases} -> {leftQuery}");
                }

                input = Console.ReadLine().Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine("Broadcasts:");
            Console.WriteLine(broadcasts.Count == 0 ? "None" : string.Join(Environment.NewLine, broadcasts));
            Console.WriteLine("Messages:");
            Console.WriteLine(messages.Count == 0 ? "None" : string.Join(Environment.NewLine, messages));
        }

        private static string ReverseCases(string rightQuery)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < rightQuery.Length; i++)
            {
                if (char.IsUpper(rightQuery[i]))
                {
                    result.Append(char.ToLower(rightQuery[i]));
                }
                else if (char.IsLower(rightQuery[i]))
                {
                    result.Append(char.ToUpper(rightQuery[i]));
                }
                else
                {
                    result.Append(rightQuery[i]);
                }
            }
            return result.ToString();
        }
    }
}
