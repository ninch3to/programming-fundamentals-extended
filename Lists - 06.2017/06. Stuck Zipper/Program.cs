using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Stuck_Zipper
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int minLenght = FindMinLenghtNumber(firstList, secondList);

            List<int> firstFilteredList = new List<int>();
            List<int> secondFilteredList = new List<int>();

            for (int i = 0; i < firstList.Count; i++)
            {
                if (FindNumberLenght(firstList[i])<=minLenght)
                {
                    firstFilteredList.Add(firstList[i]);
                }
            }
            for (int i = 0; i < secondList.Count; i++)
            {
                if (FindNumberLenght(secondList[i]) <= minLenght)
                {
                    secondFilteredList.Add(secondList[i]);
                }
            }
            List<int> result = new List<int>();
            for (int i = 0; i < Math.Max(firstFilteredList.Count, secondFilteredList.Count); i++)
            {
                if (i < secondFilteredList.Count)
                {
                    result.Add(secondFilteredList[i]);
                }
                if (i < firstFilteredList.Count)
                {
                    result.Add(firstFilteredList[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }

        private static int FindMinLenghtNumber(List<int> firstList, List<int> secondList)
        {
            int minLenght = int.MaxValue;
            for (int i = 0; i < firstList.Count; i++)
            {
                if (minLenght > FindNumberLenght(firstList[i]))
                {
                    minLenght = FindNumberLenght(firstList[i]);
                }
            }
            for (int i = 0; i < secondList.Count; i++)
            {
                if (minLenght > FindNumberLenght(secondList[i]))
                {
                    minLenght = FindNumberLenght(secondList[i]);
                }
            }

            return minLenght;
        }

        private static int FindNumberLenght(int number)
        {
            int digitCount = 0;
            number = Math.Abs(number);
            while (number > 0)
            {
                digitCount++;
                number /= 10;
            }
            return digitCount;
        }
    }
}
