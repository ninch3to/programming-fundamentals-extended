using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SoftUni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0m;

            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                string[] orderDate = Console.ReadLine().Split('/');
                int capsulesCount = int.Parse(Console.ReadLine());

                int year = int.Parse(orderDate[2]);
                int month = int.Parse(orderDate[1]);
                int daysInMonth = DateTime.DaysInMonth(year, month);

                decimal coffeePrice = (decimal)((daysInMonth * capsulesCount) * pricePerCapsule);
                Console.WriteLine("The price for the coffee is: ${0:f2}", coffeePrice);
                sum += coffeePrice;
            }

            Console.WriteLine("Total: ${0:f2}", sum);
        }
    }
}
