using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Exam_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> shopInventory = new Dictionary<string, int>();

            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "shopping")
            {
                string product = input[1];
                int quantity = int.Parse(input[2]);
                if (!shopInventory.ContainsKey(product))
                {
                    shopInventory[product] = quantity;
                }
                else
                {
                    shopInventory[product] += quantity;
                }

                input = Console.ReadLine().Split(' ');
            }

            input = Console.ReadLine().Split(' ');
            while (input[0] != "exam")
            {
                string product = input[1];
                int quantity = int.Parse(input[2]);

                if (!shopInventory.ContainsKey(input[1]))
                {
                    Console.WriteLine($"{product} doesn't exist");
                }
                else if (shopInventory[product] <= 0)
                {
                    Console.WriteLine($"{product} out of stock");
                }
                else if (quantity > shopInventory[product])
                {
                    shopInventory[product] = 0;
                }
                else
                {
                    shopInventory[product] -= quantity;
                }

                input = Console.ReadLine().Split(' ');
            }

            foreach (KeyValuePair<string,int> product in shopInventory)
            {
                if (product.Value == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"{product.Key} -> {product.Value}");
                }
            }
        }
    }
}
