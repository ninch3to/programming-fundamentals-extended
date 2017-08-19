using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Count_of_Capital_Letters_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            string[] items = values.Split(' ');
            string[] arr = new string[items.Length];

            int count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                arr[i] = items[i];
                if (arr.Length <= 1 && StartsWithUpper(arr[i]))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        static bool StartsWithUpper(string values)
        {
            return Enumerable.Range(65, 26).Contains((int)values[0]);
        }

    }
}
