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

            string mecets = Console.ReadLine();
            var noshti = double.Parse(Console.ReadLine());
            double studioDiscount = 0, doubleDiscount = 0, suiteDiscount = 0;
            double sumaStudio = 0, sumaDouble = 0, sumaSuite=0, studioPrice=0, dPrice=0, suitePrice=0;
            if ((mecets=="May")||(mecets=="October")) { studioPrice = 50;dPrice = 65;suitePrice = 75; if (noshti > 7) studioDiscount = 0.05; }
            if((mecets=="June")||(mecets=="September")) { studioPrice = 60; dPrice = 72; suitePrice = 82; if(noshti>14) doubleDiscount = 0.1; }
            if ((mecets == "July") || (mecets == "August")||(mecets=="December")) { studioPrice = 68; dPrice = 77; suitePrice = 89; suiteDiscount = 0.15; }
            sumaStudio = (studioPrice * noshti) - (studioPrice * noshti * studioDiscount);
            
            sumaDouble = (dPrice * noshti) - (dPrice * noshti * doubleDiscount);
            sumaSuite = (suitePrice * noshti) - (suitePrice * noshti * suiteDiscount);


            if ((mecets == "October") && (noshti > 7)) studioPrice = studioPrice - 60;
            if ((mecets == "September") && (noshti > 7)) studioPrice = studioPrice - 50;
            Console.WriteLine("Studio: {0:F2} lv",sumaStudio);
            Console.WriteLine("Double: {0:F2} lv", sumaDouble);
            Console.WriteLine("Suite: {0:F2} lv", sumaSuite);





        }
    }
}
