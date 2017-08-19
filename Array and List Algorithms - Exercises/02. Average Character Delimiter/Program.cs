using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Average_Character_Delimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split(' ').ToArray();
            double totalSum = 0;
            double countOfCharacters = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                string word = elements[i];
                for (int j = 0; j < word.Length; j++)
                {
                    totalSum += word[j];
                }
                countOfCharacters += word.Length;
            }
            char charDelimiter = (char)((int)(totalSum / countOfCharacters));
            string delimiter = charDelimiter.ToString().ToUpper();

            Console.WriteLine(string.Join(delimiter, elements ));
        }
    }
}
