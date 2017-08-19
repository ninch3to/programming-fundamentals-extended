using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Capitalize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            
            while (input != "end")
            {
                string[] sentence = input.Split(new char[] 
                { ',', '.', '/', '?', ';', ':', ' ', '"', '\\', '{', '}', '!','@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+' }, StringSplitOptions.RemoveEmptyEntries);


                for (int index = 0; index < sentence.Length; ++index)
                {
                    sentence[index] = ToUpperCase(sentence[index]);
                }

                Console.WriteLine(string.Join(", ", sentence));
                input = Console.ReadLine();
            }
        }
        public static string ToUpperCase(string input)
        {
            StringBuilder builder = new StringBuilder(input);

            builder[0] = char.ToUpper(builder[0]);
            return builder.ToString();

        }
    }
}
