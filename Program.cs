using System;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            // find the Greatest Common Divisor (GCD) between two numbers
            // initialize 3 variables
            // take the remainder until num3 is 0
            // GCD is num2

            int num1, num2, num3;
            bool validInput;
            do
            {
                validInput = false;
                Console.Write("Enter the first number: ");
                if (Int32.TryParse(Console.ReadLine(), out num1)) validInput = true; 
                else Console.WriteLine("Invalid input!");
            } while (!validInput);
            do
            {
                validInput = false;
                Console.Write("Enter the second number: ");
                if (Int32.TryParse(Console.ReadLine(), out num2)) validInput = true;
                else Console.WriteLine("Invalid input!");
            } while (!validInput);
            Console.Write($"The GCD of {num1} and {num2} is ");
            num3 = num1 % num2;
            while (num3 != 0)
            {
                num1 = num2;
                num2 = num3;
                num3 = num1 % num2;
            }
            Console.Write(num2);
        }
    }
}
