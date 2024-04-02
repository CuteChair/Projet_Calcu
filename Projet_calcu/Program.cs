using Projet_calcu.bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;


namespace Projet_calcu
{
    internal class Program
    {

        static void Calc()
        {
            bool ok = false;
            string Exit = "";
            CalcType currentCalc = new CalcType();
            Console.WriteLine("\n\tSimple Calculator : \n\n");
            

           symb: Console.Write("Choose the Calculation symbol (+, -, *, / ): ");
            try
            {
                currentCalc.CalcSymb = Convert.ToChar(Console.ReadLine());
            } catch { Console.WriteLine("You must choose a valid symbol!"); goto symb; }
            

            Console.WriteLine("\nPress Esc key to quit\n\n");

            if (currentCalc.CalcSymb == '+' || currentCalc.CalcSymb == '-' || currentCalc.CalcSymb == '*' || currentCalc.CalcSymb == '/')
            {
                do
                {
                firstNumb: Console.Write("Input first number : ");
                   
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        currentCalc.FirstNumb = 0;
                        currentCalc.SecondNumb = 0;
                        goto end;
                        
                    }
                   



                    try
                    {
                        currentCalc.FirstNumb = Convert.ToDouble(Console.ReadLine());
                    }
                    catch { Console.WriteLine("Please input a valid number"); goto firstNumb; }
                secNumb: Console.Write("Input second number : ");
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        currentCalc.FirstNumb = 0;
                        currentCalc.SecondNumb = 0;
                        goto end;

                    }
                    
                    try
                    {
                        currentCalc.SecondNumb = Convert.ToDouble(Console.ReadLine());
                    }
                    catch { Console.WriteLine("Please input a valid number"); goto secNumb; }

                    Console.WriteLine(currentCalc.GetCalcState());
                end: Exit = "Exit";
                } while (Exit != "Exit");
            } else { Console.WriteLine("You must choose a valid symbol!"); goto symb; }
           
           

        }

        static void UserName()
        {
            List<User> listOfUser = new List<User>();
            if (listOfUser.Count == 0)
            {
                User user = new User();
                Console.Write("Choose your user name : ");
                user.UserName = Console.ReadLine();
                user.UserId = listOfUser.Count;
                listOfUser.Add(user);
            }
            else
            {
                bool findUser = false;
                int count;
                foreach (User item in listOfUser) 
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Press Esc to create a new account or a number to find an existing one");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    User user = new User();
                    Console.Write("Choose your user name : ");
                    user.UserName = Console.ReadLine();
                    user.UserId = listOfUser.Count;
                    listOfUser.Add(user);
                }
                count = Convert.ToInt32(Console.ReadLine());

                foreach (User item in listOfUser)
                {
                    if (count = )
                }



            }
            
            
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            char choice = ' ';
            List<CalcType> listHistory = new List<CalcType>();
            
            

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

                        Calc();
                       
                       
                        break;
                    case '2': break;
                    case '3': break;
                    case '4': 
                        
                        break;

                    case '5':
                        Console.WriteLine("Youre leaving the application");
                        break;
                    default: Console.WriteLine("You must choose between 1 - 5"); break;

                }
            } while (choice != '5');

            Console.ReadKey();
        }
    }
}
