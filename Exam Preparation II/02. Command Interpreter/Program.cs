using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            string[] command = Console.ReadLine().Split(' ');

            while (command[0] != "end")
            {
                if (command[0] == "reverse")
                {

                }
                else if (command[0] == "sort")
                {

                }
                else if (command[0] == "rollLeft")
                {
                    int count = int.Parse(command[1]);
                    string[] rotatedLeft = new string[0];
                    for (int i = 0; i < count; i++)
                    {
                        rotatedLeft = RotateLeft(data);
                        data = rotatedLeft;
                    }
                    Console.WriteLine("[" + string.Join(", ", rotatedLeft) + "]");
                }
                else
                {
                    int count = int.Parse(command[1]);
                    string[] rotatedRight = new string[0];
                    for (int i = 0; i < count; i++)
                    {
                        rotatedRight = RotateRight(data);
                        data = rotatedRight;
                    }
                    Console.WriteLine("[" + string.Join(", ", rotatedRight) + "]");
                }

                command = Console.ReadLine().Split(' ');
            }
        }

        private static string[] RotateLeft(string[] data)
        {
            string[] rotatedLeft = new string[data.Length];
            for (int j = 0; j < data.Length - 1; j++)
            {
                rotatedLeft[j] = data[j + 1];
            }
            var firstElement = data[0];
            rotatedLeft[data.Length - 1] = firstElement;
            return rotatedLeft;
        }

        private static string[] RotateRight(string[] data)
        {
            string[] rotatedRight = new string[data.Length];
            for (int j = 0; j < data.Length - 1; j++)
            {
                rotatedRight[j + 1] = data[j];
            }
            var lastElement = data[rotatedRight.Length - 1];
            rotatedRight[0] = lastElement;
            return rotatedRight;
        }

       
    }
}
