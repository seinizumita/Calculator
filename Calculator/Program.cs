// See https://aka.ms/new-console-template for more information
using System;

namespace Calculator
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value is "not-a-number" if an operation, such as division, could result in an error.

            // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            //intro lines
            Console.WriteLine("Hello, welcome to the C# calculator\r");
            Console.WriteLine("-----------------------------------\n");

            while (!endApp)
            {
                //Declaring empty variables
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                //taking user input for the first number
                Console.WriteLine("please enter a number and press ENTER");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.WriteLine("this is not valid input, please enter an integer value:");
                    numInput1 = Console.ReadLine();
                }

                // Ask the user to type the second number.
                Console.Write("Type another number, and then press Enter: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput2 = Console.ReadLine();
                }

                //taking user input for the operator
                Console.WriteLine("please select an operation from the following list");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("you have selected: ");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This Operation will result in a math error\n");
                    }
                    else Console.WriteLine("your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("An exception occurred trying to do the math. \n -Details: " + e.Message);
                }

                Console.WriteLine("----------------------\n");

                //waiting for user input
                Console.WriteLine("press 'n' and ENTER to close the app, or press any button and ENTER to do another operaiton");
                if (Console.ReadLine() == "n")
                    endApp = true;

                Console.WriteLine("\n");  //line spacing
            }
            return;
        }
    }
}





