using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goit.TerraSoft.HomeWork
{
    class Lesson4
    {
        private static double result;
        private static double number;
        private static string operation;

        public static void Run()
        {
            Part1();
        }

        private static void Part1()
        {

            Console.WriteLine("Welcome to a simple calculator.\nIf you want to exit, you should enter an incorrect data or <<exit>> instead of operation");
            Console.WriteLine("<+>:Plus, <->:Minus, </>:Division, <*>:Multiple, <%>:DivByModule,<^>:Pow\n");
            while (Lesson4.operation != "exit"  )
            {

                Console.WriteLine(" -Total: "+result);
                Console.Write("Enter an operation :");
                operation = Console.ReadLine();

                if (ValidOperation(operation))
                {
                    Console.Write("Enter a number :");
                    string numberStr = Console.ReadLine();
                    if (ParseNumber(numberStr, ref Lesson4.number))
                    {
                        Result();
                    }
                    else
                    {   
                        Console.WriteLine("You must enter only number. You got a mistake. Bye!!!");
                        Console.ReadKey();
                        return;
                    }
                }
                else
                {
                    if (Lesson4.operation == "exit") continue;
                    Console.WriteLine("You entered incorrect type of operation. Bye!!!");
                    Console.ReadKey();
                    return;
                }
            }//end while
        }
        
        private static bool ParseNumber(string numStr, ref double number)
        {
            return double.TryParse(numStr,out number);
        }
        private static bool ValidOperation(string operation)
        {
            switch (operation)
            {
                case "+": 
                case "-": 
                case "/": 
                case "*": 
                case "%": 
                case "^":
                    return true;
                    
                default:
                    return false;
            }
        }
        private static void Add(){
            result += number; 
        }
        private static void Minus()
        {
            result -= number;
        }
        private static void Division()
        {
            result /= number;
        }
        private static void Pow()
        {
            result = Math.Pow(result, number);
        }
        private static void DivByModule()
        {
            result %= number;
        }
        private static void Multiple()
        {
            result *= number;
        }
        private static void Result()
        {
            switch (Lesson4.operation)
            {
                case "+": Add(); break;
                case "-": Minus(); break;
                case "/": Division(); break;
                case "*": Multiple(); break;
                case "%": DivByModule(); break;
                case "^": Pow(); break;
            }
                    
        }
    }
}
