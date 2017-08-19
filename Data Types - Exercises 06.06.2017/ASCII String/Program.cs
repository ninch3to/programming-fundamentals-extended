using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string str = String.Empty;

            for (int i = 0; i < n; i++)
            {
                int ascii = int.Parse(Console.ReadLine());
                char input = Convert.ToChar(ascii);
                str += input;
            }
            Console.WriteLine(str);
        }
    }
}
