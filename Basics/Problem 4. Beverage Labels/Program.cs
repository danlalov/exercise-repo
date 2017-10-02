using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var energy = double.Parse(Console.ReadLine());
            var sugar = double.Parse(Console.ReadLine());
            

            Console.Write("{0}ml ", volume);
            Console.WriteLine("{0}:",name);
            double content = (volume * energy) / 100;
            double s = (volume * sugar) / 100;
            Console.WriteLine("{0}kcal, {1}g sugars",content,s);



        }
    }
}
