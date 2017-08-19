using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Value_of_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            string condition = Console.ReadLine();
            int sum = 0;

            if (condition == "LOWERCASE")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsLower(input[i]) && char.IsLetter(input[i]))
                    {
                        sum += input[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsUpper(input[i]) && char.IsLetter(input[i]))
                    {
                        sum += input[i];
                    }
                }
            }
            Console.WriteLine("The total sum is: {0}", sum);
        }
    }
}
