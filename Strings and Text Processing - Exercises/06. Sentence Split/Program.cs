using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sentence_Split
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string delimiter = Console.ReadLine();
            string[] output = input.Split(new string[] { delimiter }, StringSplitOptions.None);
            Console.WriteLine("[" + string.Join(", ", output) + "]");
        }
    }
}
