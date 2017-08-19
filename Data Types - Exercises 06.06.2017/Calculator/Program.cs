using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            switch (input)
            {
                case "+":
                    Console.WriteLine("{0} {1} {2} = {3}", num1, input, num2, num1 + num2);
                    break;
                case "-":
                    Console.WriteLine("{0} {1} {2} = {3}", num1, input, num2, num1 - num2);
                    break;
                case "*":
                    Console.WriteLine("{0} {1} {2} = {3}", num1, input, num2, num1 * num2);
                    break;
                case "/":
                    Console.WriteLine("{0} {1} {2} = {3}", num1, input, num2, num1 / num2);
                    break;

            }
        }
    }
}
