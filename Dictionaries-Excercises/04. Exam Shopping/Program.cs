using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._User_Logins
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> userCredentials = new Dictionary<string, string>();

            string[] input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "login")
            {
                string username = input[0];
                string password = input[1];

                userCredentials[username] = password;

                input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }
            input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            int failed = 0;
            while (input[0] != "end")
            {
                string username = input[0];
                string password = input[1];

                if (!userCredentials.ContainsKey(username) || userCredentials[username] != password)
                {
                    Console.WriteLine($"{username}: login failed");
                    failed++;
                }
                else
                {
                    Console.WriteLine($"{username}: logged in successfully");
                }
                input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine("unsuccessful login attempts: {0}", failed);
        }
    }
}
