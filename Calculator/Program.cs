// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//delcaring variables to use as 0
double num1 = 0;
double num2 = 0;


//intro lines
Console.WriteLine("Hello, welcome to the C# calculator\r");
Console.WriteLine("-----------------------------------\n");

//taking user input for the first number
Console.WriteLine("please enter a number and press ENTER");
num1 = Convert.ToDouble(Console.ReadLine());

//taking user input for the second number
Console.WriteLine("please enter another number and press ENTER");
num2 = Convert.ToDouble(Console.ReadLine());

//taking user input for the operator
Console.WriteLine("please select an operation from the following list");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.Write("you have selected: ");

//switch statement for operators
switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Your answer is: {num1} + {num2} = " + (num1 + num2));
        break;
    case "s":
        Console.WriteLine($"Your answer is: {num1} - {num2} = " + (num1 - num2));
        break;
    case "m":
        Console.WriteLine($"Your answer is: {num1} * {num2} = " + (num1 * num2));
        break;
    case "d":
        while (num2 == 0){
            Console.WriteLine("please enter a non-zero divisor");
            num2 = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine($"Your answer is: {num1} / {num2} = " + (num1 / num2));
        break;
}

//closing app
Console.Write("Press any key to exit");
Console.ReadKey();

