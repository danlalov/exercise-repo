using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            //name, current health, maximum health, current energy and maximum energy
            var name = Console.ReadLine();
            var health = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var energy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}",name);
            Console.Write("Health: ");
            Console.Write("|");
            for (int i=0;i<maxHealth;i++)
            {
                if (i < health) Console.Write("|");
                else Console.Write(".");

            }
            Console.WriteLine("|");

            
            Console.Write("Energy: ");
            Console.Write("|");
            for (int i = 0; i < maxEnergy; i++)
            {
                if (i < energy) Console.Write("|");
                else Console.Write(".");

            }
            Console.WriteLine("|");


        }
    }
}
