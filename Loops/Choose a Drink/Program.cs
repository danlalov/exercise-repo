using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string job = Console.ReadLine();
            if (job == "Athlete") Console.WriteLine("Water");
            else if ((job == "Businessman") || (job == "Businesswoman")) Console.WriteLine("Coffee");
            else if (job == "SoftUni Student") Console.WriteLine("Beer");
            else Console.WriteLine("Tea");


        }
    }
}
