using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2
{

    enum TransactionType { Buy = 1, Sell= -1 }

    class Program
    {

                static void Main(string[] args)
        {
            //User input nominal value
            Console.WriteLine("Please insert the nominal");
            var fnominal = Console.ReadLine();
            var nominal = float.Parse(fnominal);
            Console.WriteLine($"Nominal is:  {nominal}");

            //User input trade price
            Console.WriteLine("Please insert the trade price");
            var ftradePrice = Console.ReadLine();
            var tradePrice = float.Parse(ftradePrice);
            Console.WriteLine(ftradePrice);
            Console.WriteLine($"Trade Price is:  {tradePrice}");

            //User input transaction type
            TransactionType trcType;
            Console.WriteLine("Please insert transaction type - Buy or Sell");
            string userInput = Console.ReadLine();
            trcType = (TransactionType)Enum.Parse(typeof(TransactionType), userInput, true);
            
            //Current value calculation

           double currentValue = ((double)trcType) * nominal * tradePrice;

           Console.WriteLine($"The current value of transaction is: {currentValue}");


                      
           Console.ReadLine();
        }
    }
}
