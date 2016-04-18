using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_control
{
    //this class contains most of the messages that will be seen throughout the program.
    public class Messages
    {
        public static void Code(int nb)
        {
            switch(nb)
            {
                //message to be displayed if a value is incorrectly formated.
                case 1:
                    Console.WriteLine("The value entered is not a date or is incorrectly formatted, please try again");
                    break;
                    
                case 2:
                    Console.WriteLine("The value entered is not a number, please try again.");
                    break;

                    //message tobe displayed if duplicate of product ID is found.
                case 3:
                    Console.WriteLine("You cannot use the same ID on more than 1 product, please use a different ID.");
                    break;

                    //message to be displayed if there is no stock.
                case 4:
                    Console.WriteLine("The store currently has no stock, please get more.\n");
                    break;

                    //message to be displayed in when a process has finished.
                case 5:
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadLine();
                    break;

                    //message to be displayed if selected option is out of range.
                case 6:
                    Console.WriteLine("Selected option does not exist, please select one of the numbers displayed above.");
                    break;

                    //message to be displayed if help option is selected.
                case 7:
                    Console.WriteLine("expiry Date:\n\tYou may ommit the time from the expiry date in which case, the time will automatically"+
                        "\n\tbe set to 00:00:00 of that date.\n\nItem limit:\n\tThis program can store a maximum of 99999 different products.\n\n"+
                        "Eat_\nSleep_\nCode_\n");
                    break;
            }
        }
    }
}
