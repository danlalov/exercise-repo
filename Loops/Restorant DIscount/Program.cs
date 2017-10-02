using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {

            double placePrice = 0;



            var group = double.Parse(Console.ReadLine());
            string pak = Console.ReadLine();
            double discount = 0.00;
            double paketPrice = 0.00;
            int end = 0;
            string hallName = pak;
            double suma = 0.00;
            double fullDiscount = 0.00;
            double totalPrice = 0.00;
            double personPrice = 0.00;


            if (pak == "Normal") { paketPrice = 500; discount = 0.05; }
            if (pak == "Gold") { paketPrice = 750; discount = 0.10; }
            if (pak == "Platinum") { paketPrice = 1000; discount = 0.15; }


            if (group < 51) { placePrice = 2500; hallName = "Small Hall"; }


            if ((group > 50) && (group < 101)) { placePrice = 5000; hallName = "Terrace"; }


            if ((group > 100) && (group < 121)) { placePrice = 7500; hallName = "Great Hall"; }

            if (group > 120)
            {
                end = 1;
                Console.WriteLine("We do not have an appropriate hall.");
            }
            if (end == 0)
            {


                suma = (placePrice + paketPrice);
               
                

                fullDiscount = suma * discount;
                
               

                totalPrice = suma - fullDiscount;
               
                

                personPrice = totalPrice / group;
                
                

                Console.WriteLine("We can offer you the {0}", hallName);
                Console.WriteLine("The price per person is {0:F2}$", personPrice);




            }

        }
    }
}
