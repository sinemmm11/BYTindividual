using System;
using Tut2_s20123;

namespace BYT3{

    class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator();

            Console.WriteLine("Welcome to the Calculator!");
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose operation (+, -, *, /): ");
            string op = Console.ReadLine();

            try
            {
                double result = op switch
                {
                    "+" => calc.Add(num1, num2),
                    "-" => calc.Subtract(num1, num2),
                    "*" => calc.Multiply(num1, num2),
                    "/" => calc.Divide(num1, num2),
                    _ => throw new InvalidOperationException("Invalid operation.")
                };

                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}