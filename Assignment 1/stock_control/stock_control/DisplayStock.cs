using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_control
{
    //displays the contents of the array.
    class DisplayStock : StockControl
    {
        public DisplayStock()
        {
            Console.Clear();
            dispBanner();
            Console.WriteLine("\t\t\t\t\t\tDisplay Stock levels.\n");
            
        }
        //display the details of each product in stock.
        public void displayStock()
        {
            int i = 0;
            int counter = _counter;
            if (counter > 0)
                while (counter > 0)
                {
                    Console.WriteLine(_stocklist[i, 1] + " :");
                    Console.WriteLine("\tID, " + _stocklist[i, 0]);
                    Console.WriteLine("\tExpiry Date, " + _stocklist[i, 2]);
                    Console.WriteLine("\tUnit Selling Price, R " + _stocklist[i, 3]);
                    Console.WriteLine("\tUnits in Stock, " + _stocklist[i, 4] + "\n");
                    Console.WriteLine("\tTotal Selling Price, R " + (Double.Parse(_stocklist[i, 3]) * Double.Parse(_stocklist[i, 4])) + "\n");
                    counter--;
                    i++;
                }
            else
                Messages.Code(4);
            Messages.Code(5);
        }
    }
}
