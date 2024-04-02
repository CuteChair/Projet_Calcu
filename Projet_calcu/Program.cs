using Projet_calcu.bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projet_calcu
{
    internal class Program
    {

     

        static void Main(string[] args)
        {
            char choice = ' ';
            List<CalcType> listHistory = new List<CalcType>();
            int currentFirstNumber, currentSecondNumber, currentCalcSymb;

            do
            {
                Console.WriteLine("\tSimple calculator" +
                    "" +
                    "\n\nChoose your option :" +
                    "" +
                    "\n -1- Acces the simple calculator : " +
                    "\n -2- View the history :" +
                    "\n -3- Acces Mini Game :" +
                    "\n -4- Change user :" +
                    "\n -5- Exit the application : ");

                Console.Write("\n\nYour Choice : ");
                try
                {
                    choice = Convert.ToChar(Console.ReadLine());
                }
                catch { Console.WriteLine("You must choose between 1 - 5"); }

                switch (choice)
                {
                    case '1':
                        char opt = ' ';

                        do
                        {
                            Console.WriteLine("\n\tWelcome to the simple calculator, please choose from these options : " +
                           "" +
                           "\n -1- Addition (+) " +
                           "\n -2- Substraction (-)" +
                           "\n -3- Multiplication (x)" +
                           "\n -4- Division (/)" +
                           "\n -5- Go Back to Menu");
                            Console.Write("\n\nYour Choice : ");
                            try
                            {
                                opt = Convert.ToChar(Console.ReadLine());
                            } catch { Console.WriteLine("You must choose between 1 - 5"); }
                            
                            switch(opt)
                            {
                                case '1': break;
                                case '2': break;
                                case '3': break;
                                case '4': break;
                                default: Console.WriteLine("You must choose between 1 - 5"); break;

                            }

                        } while (opt != '5');
                       
                        break;
                    case '2': break;
                    case '3': break;
                    case '4': break;
                    case '5': break;
                    default: Console.WriteLine("You must choose between 1 - 5"); break;

                }
            } while (choice != '5');

            Console.ReadKey();
        }
    }
}
