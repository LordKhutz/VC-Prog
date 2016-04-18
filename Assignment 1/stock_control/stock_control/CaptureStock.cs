using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_control
{
    //captures stock.
    class CaptureStock : StockControl
    {
        public CaptureStock()
        {
            _counter = 0;
        }

        public int captureStock()
        {
            String reader;
            int intVal = 0;
            Double dblVal = 0.0;
            DateTime expDate;
            int exit = 0;

            dispBanner();
            Console.WriteLine("\t\t\t\t\t\tCapture new stock.\n");

            Console.WriteLine("please enter the product ID  or 999 to quit>> ");
            reader = Console.ReadLine();
            //checks for duplicates of the product ID.
            if (_counter > 0)
            {
                while (reader == _stocklist[_counter - 1, 0])
                {
                    Messages.Code(3);
                    reader = Console.ReadLine();
                }
            }
            //checks if the escape code has been entered.
            if (int.TryParse(reader, out exit))
                if (exit == 999)
                    return (exit);
            _stocklist[_counter, 0] = reader;
            Console.WriteLine("please enter the product Name >> ");
            _stocklist[_counter, 1] = Console.ReadLine();
            //this checks if the user input is a date and continues if it is. 
            Console.WriteLine("please enter the product expiry date in YYYY/MM/DD HH:MM format>> ");
            while (!(DateTime.TryParse(Console.ReadLine(), out expDate)))
                Messages.Code(1);
            _stocklist[_counter, 2] = Convert.ToString(expDate);
            //this checks if the user input is currency format and continues if it is.
            Console.WriteLine("please enter the product unit selling price int decimal format (without the R)>> ");
            while (!(Double.TryParse(Console.ReadLine(), out dblVal)))
                Messages.Code(2);
            _stocklist[_counter, 3] = Convert.ToString(dblVal);
            //this checks if the user input is a number, continues if it is.
            Console.WriteLine("please enter the number of units recieved >> ");
            while (!(int.TryParse(Console.ReadLine(), out intVal)))
                Messages.Code(2);
            _stocklist[_counter, 4] = Convert.ToString(intVal);
            return (0);
        }

    }
}
