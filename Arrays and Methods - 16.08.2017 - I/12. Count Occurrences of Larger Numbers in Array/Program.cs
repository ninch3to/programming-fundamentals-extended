using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Count_Occurrences_of_Larger_Numbers_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            double numberToFind = double.Parse(Console.ReadLine());

            int count = 0;
            string[] items = numbers.Split(' ');

            double[] arr = new double[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                arr[i] = double.Parse(items[i]);
                if (arr[i] > numberToFind)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
