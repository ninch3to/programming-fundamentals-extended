using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits_with_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string digit = Console.ReadLine();
            switch (digit)
            {
                case "nine":
                    Console.WriteLine("9");
                    break;
                case "eight":
                    Console.WriteLine("8");
                    break;
                case "seven":
                    Console.WriteLine("7");
                    break;
                case "six":
                    Console.WriteLine("6");
                    break;
                case "five":
                    Console.WriteLine("5");
                    break;
                case "four":
                    Console.WriteLine("4");
                    break;
                case "three":
                    Console.WriteLine("3");
                    break;
                case "two":
                    Console.WriteLine("2");
                    break;
                case "one":
                    Console.WriteLine("1");
                    break;
            }
        }
    }
}
