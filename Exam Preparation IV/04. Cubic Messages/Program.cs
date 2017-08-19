using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Cubic_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<firstIndecies>^[?<=\d]+)(?<message>[a-zA-Z]+)(?<secondIndecies>[^a-zA-Z]*)$";
            Regex cubicRegex = new Regex(pattern);

            string input = Console.ReadLine();

            while (input != "Over!")
            {
                int charCount = int.Parse(Console.ReadLine());
                if (cubicRegex.IsMatch(input))
                {
                    Match match = cubicRegex.Match(input);
                    string message = match.Groups["message"].Value;
                    if (message.Length == charCount)
                    {
                        string firstIndecies = match.Groups["firstIndecies"].Value;
                        int[] fdsfg = firstIndecies.Split().Select(int.Parse).ToArray();
                        StringBuilder result = new StringBuilder();
                        for (int i = 0; i < fdsfg.Length; i++)
                        {
                            result.Append(message[i]);
                        }
                    }
                }


                input = Console.ReadLine();
            }
        }
    }
}
