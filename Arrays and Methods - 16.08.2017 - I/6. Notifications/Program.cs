using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Notifications
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string operation = " ";
            string operation2 = "";
            string result = " ";
            string message = " ";
            int code = 0;

            for (int i = 0; i < n; i++)
            {
                 result = Console.ReadLine();

                if (result == "success")
                {
                     operation = Console.ReadLine();
                     message = Console.ReadLine();
                    Console.WriteLine(ShowSuccess(operation, message));
                }
                else if (result == "error")
                {
                     operation2 = Console.ReadLine();
                     code = int.Parse(Console.ReadLine());
                    Console.WriteLine(ShowError(operation2, code));
                }
                else
                {
                    continue;
                }
            }       
        }
        static string ShowSuccess(string operation, string message)
        {
            string result1 = string.Format($"Successfully executed {operation}.\n==============================\nMessage: {message}.");
            return result1;
        }
        static string ShowError(string operation, int code)
        {
            string reason = " ";
            if (code >= 0)
            {
                reason = "Invalid Client Data";
            }
            else
            {
                reason = "Internal System Failure";
            }
            string result2 = string.Format($"Error: Failed to execute {operation}.\n==============================\nError Code: {code}.\nReason: {reason}.");
            return result2;
        }

    }
}
