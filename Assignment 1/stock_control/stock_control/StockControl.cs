using System;

namespace stock_control
{
    public class StockControl 
    {
        protected static String[,] _stocklist;
        protected static int _counter = 0;
        //set the value of the array.
        public String[,] stocklist
        {
            set
            {
                _stocklist = value;
            }
        }

        //set the value of the counter.
        public int counter
        {
            set
            {
                _counter = value;
            }
        }
        //display the contants of the main manu.
        public int Menu()
        {
            Console.Clear();
            dispBanner();
            Console.WriteLine("\t\t\t\t\t\t\tMain Menu\n");
            Console.WriteLine("please choose the number that represents the function you wish to perform.\n");
            Console.WriteLine("1 >> Capture Stock");
            Console.WriteLine("2 >> Display Stock levels");
            Console.WriteLine("3 >> Help");
            Console.WriteLine("4 >> Exit Application");

            int selectedOption = 0;
            if (int.TryParse(Console.ReadLine(), out selectedOption))
                return (selectedOption);
            Messages.Code(2);
            _counter--;
            return (0);
           
        }

        //this method displays the banner of the store.
        protected void dispBanner()
        {
            Console.Clear();
            Console.WriteLine("********************************************************************************************************************");
            Console.WriteLine("*                              MMMMMMMM          MMMMMMM      KKKK       KK                                        *");
            Console.WriteLine("*                              MMMMMMMM MMMM  MM MMMMMMM      KKKK    KK                                           *");
            Console.WriteLine("*                              MMMMMMMM     MM   MMMMMMM      KKKK  KK                                             *");
            Console.WriteLine("*                              MMMMMMMM          MMMMMMM      KKKK      KK                                         *");
            Console.WriteLine("*                              MMMMMMMM          MMMMMMM  ,,  KKKK         KK                                      *");
            Console.WriteLine("*                                                    SUPER - STORE                                                 *");
            Console.WriteLine("*                                                                                                                  *");
            Console.WriteLine("********************************************************************************************************************");
        }
        //display the contents of the help option.
        public void help()
        {
            dispBanner();
            Console.WriteLine("\t\t\t\t\t\tHelp.\n");
            Messages.Code(7);
            Messages.Code(5);
        }
    }
}