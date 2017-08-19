using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Deserialize_String
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, char> letterIndicies = new SortedDictionary<int, char>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] tokens = input.Split(':');
                char @char = tokens[0][0];
                int[] indicies = tokens[1].Split('/').Select(int.Parse).ToArray();

                foreach (int index in indicies)
                {
                    letterIndicies[index] = @char;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(letterIndicies.Values.ToArray());
        }
    }
}
