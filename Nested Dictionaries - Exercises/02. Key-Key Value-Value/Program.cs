using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Key_Key_Value_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyToFind = Console.ReadLine();
            string valueToFind = Console.ReadLine();
            int cnt = int.Parse(Console.ReadLine());

            var data = new Dictionary<string, List<string>>();

            for (int i = 0; i < cnt; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);
                string key = input[0];
                if (!data.ContainsKey(key))
                {
                    data[key] = new List<string>();
                }

                string[] values = input[1].Split(';');

                foreach (var value in values)
                {
                    data[key].Add(value);
                }
            }

            foreach (var record in data)
            {
                string outputKey = record.Key;
                List<string> outputValues = record.Value;

                if (outputKey.Contains(keyToFind))
                {
                    Console.WriteLine(outputKey + ":");
                    foreach (string outputvalue in outputValues)
                    {
                        if (outputvalue.Contains(valueToFind))
                        {
                            Console.WriteLine("-" + outputvalue);
                        }
                    }

                }
            }
        }
    }
}
