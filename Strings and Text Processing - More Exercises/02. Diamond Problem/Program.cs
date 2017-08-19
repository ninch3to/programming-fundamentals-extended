using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Diamond_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            bool isFound = false;

            int leftIndex = -1;
            int rightIndex = -1;

            while ((leftIndex = input.IndexOf('<', leftIndex + 1)) > -1
                && (rightIndex = input.IndexOf('>', leftIndex + 1)) > -1)
            {
                string diamondContent = input.Substring(leftIndex + 1, rightIndex - leftIndex - 1);
                int carats = FindCarats(diamondContent);
                Console.WriteLine($"Found {carats} carat diamond");
                isFound = true;
            }
            if (!isFound)
            {
                Console.WriteLine("Better luck next time");
            }
        }

        private static int FindCarats(string diamondContent)
        {
            int carats = 0;
            foreach (char @char in diamondContent)
            {
                if (char.IsDigit(@char))
                {
                    carats += int.Parse(@char.ToString());
                }
            }
            return carats;
        }
    }
}
