using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int proizvedenie = 1, totalSum = 0, combination = 0 ;
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var limit = int.Parse(Console.ReadLine());
            for (int i = a; i >= 1; i--)
            {
                if (totalSum >= limit) return;
                for (int j = 1; j <= b; j++)
                {

                     totalSum = totalSum + (3 * (i * j));
                    combination++;

                    if (totalSum >= limit)
                    {
                        Console.WriteLine("{0} combinations", combination);
                        Console.WriteLine("Sum: {0} >= {1}", totalSum, limit);
                       return;

                    }

                   

                }
            }
            if (totalSum < limit)
            {
                Console.WriteLine("{0} combinations", combination);
                Console.WriteLine("Sum: {0}", totalSum);
            }



        }
    }
}
