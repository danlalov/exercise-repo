using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interval_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            int max = b, min = a, c=-1;
            if (max < min) { c = max; max = min; min = c; }
            for(int i=min; i<=max;i++)
                Console.WriteLine(i);


        }
    }
}
