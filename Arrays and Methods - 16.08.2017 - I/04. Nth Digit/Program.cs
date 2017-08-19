using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Nth_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(FindNthDigit(number, index));
        }
        static long FindNthDigit(long number, int index)
        {
            int currentIndex = 1;
            while (number != 0)
            {
                if (currentIndex == index)
                {
                    return number % 10;
                }
                currentIndex++;
                number /= 10;
            }
            return number % 10;
        }

    }
}
