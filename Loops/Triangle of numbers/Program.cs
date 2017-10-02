using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            var x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("{0} ",n);
                Console.WriteLine();
                n++;
            }
        }
    }
}
