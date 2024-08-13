using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            string userSelection = "";

            do
            {
                Console.Clear(); 
                Console.WriteLine("Calculator Experience");
                Console.WriteLine("Please type a number and then press enter");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please type another number and press enter");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Select an option");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.WriteLine("\tq - Quit");
                Console.Write("Your option? ");

                userSelection = Console.ReadLine();
                switch (userSelection)
                {
                    case "a":
                        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                        break;
                    case "s":
                        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                        break;
                    case "m":
                        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                        break;
                    case "d":
                        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                        break;
                    case "q":
                        Console.WriteLine("Exiting Calculator...");
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please select a valid option.");
                        break;
                }

                if (userSelection != "q")
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }

            } while (userSelection != "q");

            Console.WriteLine("Thank you for using the calculator!");
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}
