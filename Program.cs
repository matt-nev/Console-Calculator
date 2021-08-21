using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number");
            var num = Console.ReadLine();
            var number = Convert.ToInt32(num);
        }
    }
}
