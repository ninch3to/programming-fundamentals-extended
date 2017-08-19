using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Equal_Sequence_of_Elements_in_Array
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
            bool isSame = true;

            for (int i = 0; i < items.Length; i++)
            {
                if (array[i] == currentInt)
                {
                    currentInt = array[i];
                }
                else
                {
                    isSame = false;
                    break;
                }
            }
            if (isSame)
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
