using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Formations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            while (a + b < c || a + c < b || b + c < a)
            {
                Console.WriteLine("Invalid Triangle.");
                break;
            }
            if (a * a + b * b == c * c || b * b + c * c == a * a || c * c + a * a == b * b)
            {
                if (a * a + b * b == c * c)
                {
                    Console.WriteLine("Triangle is valid.");
                    Console.WriteLine("Triangle has a right angle between sides a and b");
                }
                else if (b * b + c * c == a * a)
                {
                    Console.WriteLine("Triangle is valid.");
                    Console.WriteLine("Triangle has a right angle between sides b and c");
                }
                else if (c * c + a * a == b * b)
                {
                    Console.WriteLine("Triangle is valid.");
                    Console.WriteLine("Triangle has a right angle between sides a and c");
                }

            }
            else if (a == b && b == c)
            {
                Console.WriteLine("Triangle is valid.");
                Console.WriteLine("Triangle has no right angles");
            }
        }
    }
}
