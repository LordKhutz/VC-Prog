using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_control
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the stock capture object that inherits from the StockControl class
            CaptureStock cptrStk = new CaptureStock();
            DisplayStock dspStk;
            int counter = 0;
            int selectedOption = 0;

            //create the array to store the stock.
            cptrStk.stocklist = new String[99999, 5]; ;

            //run program until user disides to quit exacution.
            do
            {
                //display the main manu.
               selectedOption = cptrStk.Menu();
               switch (selectedOption)
                {
                    //perform tasks for the first manu option.
                    case 1:
                        while(cptrStk.captureStock() != 999)
                        {
                            counter++;
                            cptrStk.counter = counter;
                        };
                        break;

                    //perform tasks for the second menu option.
                    case 2:
                        dspStk = new DisplayStock();
                        dspStk.displayStock();
                        break;

                   //perform tasks for the third menu option.
                    case 3:
                        cptrStk.help();
                        break;

                    //perform tasks for the fourth menu option.
                    case 4:
                        break;
                    
                    //perform tasks of invalid manu option codes.
                    default:
                        Messages.Code(6);
                        Messages.Code(5);
                        break;
                }
                //program stops exacution when the terminate menu option is selected.
            } while (selectedOption != 4);
        }
    }
}