using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Grand Circus' Room Detail Generator";
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!\n");
            while (true)
            {
                Console.WriteLine("Enter Length:");
                string lengthInput = Console.ReadLine();
                if (!isValidInput(lengthInput))
                {
                    break;
                }
                double length = Double.Parse(lengthInput);

                Console.WriteLine("Enter Width:");
                string widthInput = Console.ReadLine();
                if (!isValidInput(widthInput))
                {
                    break;
                }
                double width = Double.Parse(widthInput);

                double area = length * width;
                double perimeter = (length * 2) + (width * 2);

                Console.WriteLine("\tArea: " + area);
                Console.WriteLine("\tPerimeter: " + perimeter);

                if (continueProgram())
                {
                    continue;
                }
                return;
            }
        }
        public static bool isValidInput(string x)
        {
            double temp;
            if (!Double.TryParse(x, out temp))
            {
                error();
                return false;
            }
            return true;
        }
        public static void error()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Invalid input!");
        }
        public static bool continueProgram()
        {
            Console.WriteLine("\nContinue? (y/n):");

            string loop = Console.ReadLine().ToLower();
            Console.WriteLine();
            if (loop == "y")
            {
                return true;
            }
            if (loop == "n")
            {
                return false;
            }
            else
            {
                error();
                return false;
            }
        }
    }
}
