using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Count_of_Given_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            int numberToFind = int.Parse(Console.ReadLine());
            int count = 0;
            string[] items = numbers.Split(' ');

            int[] arr = new int[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                arr[i] = int.Parse(items[i]);
                if (arr[i] == numberToFind)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
