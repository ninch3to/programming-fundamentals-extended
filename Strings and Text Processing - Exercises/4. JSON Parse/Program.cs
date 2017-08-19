using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.JSON_Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.Substring(2, input.Length - 2 - 2);
           
            string[] studentTokens = input.Split(new string[] { "},{" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var studentToken in studentTokens)
            {
                string[] students = studentToken.Split(new string[] { "name:\"", "\",age:", ",grades:" }, StringSplitOptions.RemoveEmptyEntries);
                
                string name = students[0];
                int age = int.Parse(students[1]);
                string grades = students[2].Substring(1, students[2].Length - 2);

                if (grades == "")
                {
                    Console.WriteLine(name + " : " + age + " -> None");
                }
                else
                {
                    Console.WriteLine(name + " : " + age + " -> " + grades);
                }
                
            }
        }
    }
}
