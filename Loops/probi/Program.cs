using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            if ((k - n) < 4) Console.WriteLine("No");
            else
            {
                for (int a = n; a <= k - 4; a++)
                    for (int b = a + 1; b <= k - 3; b++)
                        for (int c = b + 1; c <= k - 2; c++)
                            for (int d = c + 1; d <= k - 1; d++)
                                for (int e = d + 1; e <= k; e++)
                                    Console.WriteLine("{0} {1} {2} {3} {4}", a, b, c, d, e);
            }
        }
    }
}