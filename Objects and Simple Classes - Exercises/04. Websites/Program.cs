using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Websites
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Website> websites = new List<Website>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputTokens = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
                string host = inputTokens[0];
                string domain = inputTokens[1];
                string[] queries;
                if (inputTokens.Count() > 2)
                {
                    queries = inputTokens[2].Split(',').ToArray();
                }
                else
                {
                    queries = new string[0];
                }
                websites.Add(new Website(host, domain, queries));
                input = Console.ReadLine();
            }

            foreach (var website in websites)
            {
                Console.Write("https://www.{0}.{1}", website.Host, website.Domain);

                if (website.Queries.Count() > 0)
                {
                    Console.Write("/query?=[{0}]", string.Join("]&[", website.Queries));
                }
                Console.WriteLine();
            }
        }
    }

    class Website
    {
        public string Host { get; set; }
        public string Domain { get; set; }
        public string[] Queries { get; set; }

        public Website(string host, string domain, string[] queries)
        {
            this.Host = host;
            this.Domain = domain;
            this.Queries = queries;
        }
    }
}
