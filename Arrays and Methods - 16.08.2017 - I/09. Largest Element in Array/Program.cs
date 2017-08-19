using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Largest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var array = new int[count];
            int minValue = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] > minValue)
                {
                    minValue = array[i];
                }
            }
            Console.WriteLine(minValue);
        }
    }
}
