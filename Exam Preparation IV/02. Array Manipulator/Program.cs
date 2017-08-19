using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Manipulator
{
   public class Program
    {
        static int[] numbers;
        public static void Main()
        {
            numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] tokens = input.Split(' ');

                ParseCommand(tokens);
                
                input = Console.ReadLine();
            }
            Console.WriteLine("[{0}]", string.Join(", ", numbers));
        }
        private static void ParseCommand(string[] tokens)
        {
            switch (tokens[0])
            {
                case "exchange":
                    {
                        int index = int.Parse(tokens[1]);
                        if (index >= 0 && index < numbers.Length)
                        {
                            numbers = Exchange(index);
#if DEBUG
                            Console.WriteLine("[{0}]", string.Join(", ", numbers));
#endif
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                       
                        break;
                    }
                case "max":
                    {
                        int isOdd = ParseIsOdd(tokens[1]);
                        int max = Max(isOdd);
                        if (max >= 0)
                        {
                            Console.WriteLine(max);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                        break;
                    }
                case "min":
                    {
                        int isOdd = ParseIsOdd(tokens[1]);
                        int min = Min(isOdd);
                        if (min>=0)
                        {
                            Console.WriteLine(min);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                        break;
                    }
                case "first":
                    {
                        int count = int.Parse(tokens[1]);
                        int isOdd = ParseIsOdd(tokens[2]);
                        if (count >= 0 && count <= numbers.Length)
                        {
                            int[] firstElement = First(count, isOdd);
                            Console.WriteLine("[{0}]", string.Join(", ", firstElement));
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                        break;
                    }
                case "last":
                    {
                        int count = int.Parse(tokens[1]);
                        int isOdd = ParseIsOdd(tokens[2]);
                        if (count >= 0 && count <= numbers.Length)
                        {
                            int[] lastElement = Last(count, isOdd);
                            Console.WriteLine("[{0}]", string.Join(", ", lastElement));
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                        
                        break;
                    }
            }
        }

        private static int ParseIsOdd(string input)
        {
            return input == "odd" ? 1 : 0;
        }

        static int[] Exchange(int index)
        {
            var firstElements = numbers.Take(index + 1);
            var secondElements = numbers.Skip(index + 1);
            return secondElements.Concat(firstElements).ToArray();
        }

        static int Max(int isOdd)
        {
            var filteredElements = numbers.Where(n => n % 2 == isOdd);
            int max;
            if (filteredElements.Count() > 0)
            {
                max = filteredElements.Max();
            }
            else
            {
                return -1;
            }
            return numbers.ToList().LastIndexOf(max);
        }

        static int Min(int isOdd)
        {
            var filteredElements = numbers.Where(n => n % 2 == isOdd);
            int min;
            if (filteredElements.Count() > 0)
            {
                min = filteredElements.Min();
            }
            else
            {
                return -1;
            }
            return numbers.ToList().LastIndexOf(min);
        }

        static int[] First(int count, int isOdd)
        {
            int[] firstElements = numbers.Where(n => n % 2 == isOdd).Take(count).ToArray();
            return firstElements;
        }

        static int[] Last(int count, int isOdd)
        {
            int[] lastElements = numbers.Where(n => n % 2 == isOdd).Reverse().Take(count).Reverse().ToArray();
            return lastElements;
        }
    }
}
