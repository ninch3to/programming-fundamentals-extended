using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tricky_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string message = String.Empty;

            for (int i = 0; i < n-1; i++)
            {
                string input = Console.ReadLine();
                message += input;
                message += delimiter;
            }
            string input2 = Console.ReadLine();
            message += input2;
            Console.WriteLine(message);
            
        }
    }
}
