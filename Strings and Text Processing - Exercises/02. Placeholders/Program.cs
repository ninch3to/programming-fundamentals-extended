using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Placeholders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputTokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string sentence = inputTokens[0];
                string[] values = inputTokens[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                for (int index = 0; index < values.Length; ++index)
                {
                    string value = values[index];
                    string placeholder = "{" + index + "}";

                    sentence = sentence.Replace(placeholder, value);
                }

                Console.WriteLine(sentence);

                input = Console.ReadLine();
            }

        }
    }
}

