using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Increasing_Sequence_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string integers = Console.ReadLine();
            string[] items = integers.Split(' ');

            int[] array = new int[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                array[i] = int.Parse(items[i]);
            }
            int currentInt = array[0];
            bool isBigger = true;

            for (int i = 0; i < items.Length; i++)
            {
                if (array[i] > currentInt || array[i] == currentInt)
                {
                    currentInt = array[i];
                }
                else if (array[i] < currentInt)
                {
                    isBigger = false;
                    break;
                }
            }
            if (isBigger)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
