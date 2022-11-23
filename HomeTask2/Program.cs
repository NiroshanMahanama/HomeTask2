using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the nominal value");
            var nominal = Console.ReadLine();
            var fnominal = float.Parse(nominal);
            Console.WriteLine($"The Nominal Value is:  {fnominal}");

            Console.WriteLine("Please insert the trade price");
            var tradePrice = Console.ReadLine();
            var ftradePrice = float.Parse(tradePrice);
            Console.WriteLine(ftradePrice);
            Console.WriteLine($"The Trade Price is:  {ftradePrice}");


            /*
            var nominal = 33.33f;
            var tadePrice = 33.33f;

            Console.WriteLine("Please input 2nd numner");
            string secondNumber = Console.ReadLine();
            int intsecondNumber = int.Parse(secondNumber);

            */
            Console.ReadLine();
        }
    }
}
