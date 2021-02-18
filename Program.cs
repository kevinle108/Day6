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

            // also find the Least Common Multiple (LCM) between two numbers
            // LCD = (num1 * num2) / GCD

            int num1, num2, num3;
            int originalNum1, originalNum2;
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
            originalNum1 = num1; 
            originalNum2 = num2;
            
            num3 = num1 % num2;
            while (num3 != 0)
            {
                num1 = num2;
                num2 = num3;
                num3 = num1 % num2;
            }
            Console.WriteLine($"The GCD of {originalNum1} and {originalNum2} is {num2}.");
            Console.WriteLine($"The LCM of {originalNum1} and {originalNum2} is {(originalNum1 * originalNum2) / num2}.");
        }
    }
}
