using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 0; int number2 = 0;

            try
            {
                Console.WriteLine("Enter a number");
                number1 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("An error occured.");
            }
            finally
            {
                Console.WriteLine("Please try again.");
            }

            Console.WriteLine("Enter a number");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose from the following list:");
            Console.WriteLine("+ - Add");
            Console.WriteLine("- - Subtract");
            Console.WriteLine("* - Multiply");
            Console.WriteLine("/ - Divide");
            Console.WriteLine("your pick?");

            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine($"Result: {number1} + {number2} = " + (number1 + number2));
                    break;
                case "-":
                    Console.WriteLine($"Result: {number1} - {number2} = " + (number1 - number2));
                    break;
                case "*":
                    Console.WriteLine($"Result: {number1} * {number2} = " + (number1 * number2));
                    break;
                case "/":
                    Console.WriteLine($"Result: {number1} / {number2} = " + (number1 / number2));
                    break;
            }
        }
    }
}
