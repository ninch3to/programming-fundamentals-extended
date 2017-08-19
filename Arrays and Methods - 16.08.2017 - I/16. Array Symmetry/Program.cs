using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Array_Symmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();




            string[] items = values.Split(' ');
            string[] arr = new string[items.Length];
            string str = "";

            for (int i = 0; i < items.Length; i++)
            {
                arr[i] = items[i];
                str += items[i];
            }
            char[] newStr = str.ToArray();
            
            //Console.WriteLine(newStr);
            Array.Reverse(arr);

           

          //  Console.WriteLine(newStr);
        }
    }
}
