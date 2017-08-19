using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            double bananaCost = double.Parse(Console.ReadLine());
            double eggCost = double.Parse(Console.ReadLine());
            double berriesKiloCost = double.Parse(Console.ReadLine());
            int portionSets = 0; ;

            if (guests % 6 == 0)
            {
                portionSets = guests / 6;
            }
            else
            {
                portionSets = 1 + (guests / 6);
            }

            double totalCost = portionSets * ((2 * bananaCost) + (4 * eggCost) + (0.2 * berriesKiloCost));

            if (totalCost <= budget)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", totalCost);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:F2}lv more.", totalCost - budget);
            }
        }
    }
}
