using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.JSON_Stringify
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();
            string input = Console.ReadLine();

            while (input != "stringify")
            {
                string[] inputTokens = input.Split(new string[] { " : ", " ->" }, StringSplitOptions.RemoveEmptyEntries);

                string name = inputTokens[0];
                int age = int.Parse(inputTokens[1]);
                string[] grades = new string[] { };

                if (inputTokens.Length > 2)
                {
                    grades = inputTokens[2]
                        .Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);
                }

                if (text.Length != 0)
                {
                    text.Append(",");
                }

                text.Append("{");
                text.Append(
                    string.Format("name:\"{0}\",age:{1},grades:[{2}]",
                        name, age, string.Join(", ", grades)));
                text.Append("}");

                input = Console.ReadLine();
            }
            Console.WriteLine("[{0}]", text.ToString());
        }
    }
}
