using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Find_the_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] tokens = Console.ReadLine().Split();
            string letter = tokens[0];
            int occurence = int.Parse(tokens[1]);

            int index = -1;
            do
            {
                occurence--;
                index = text.IndexOf(letter, index + 1);
            } while (index != -1 && occurence > 0);

            if (index != -1)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("Find the letter yourself!");
            }
        }
    }
}
