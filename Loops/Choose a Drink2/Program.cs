using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_a_Drink2
{
    class Program
    {
        static void Main(string[] args)
        {
            string job = Console.ReadLine();
            var number = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            //The   has to pay  .
            if (job == "Athlete")
            {
                totalPrice = number * 0.70;
                Console.WriteLine("The {0} has to pay {1:F2}.", job, totalPrice);
            }
            else if ((job == "Businessman") || (job == "Businesswoman"))
            { totalPrice = number * 1.00; Console.WriteLine("The {0} has to pay {1:F2}.", job, totalPrice); }
            else if (job == "SoftUni Student")
                { totalPrice = number * 1.70; Console.WriteLine("The {0} has to pay {1:F2}.", job, totalPrice); }
                else { totalPrice = number * 1.20; Console.WriteLine("The {0} has to pay {1:F2}.", job, totalPrice); }

        }
    }
}
