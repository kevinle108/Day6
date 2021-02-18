using System;
using System.Collections.Generic;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2, num3;
            int originalNum1, originalNum2, originalNum3;
            while (true)
            {
                Console.Write("Enter the first number: ");
                if (Int32.TryParse(Console.ReadLine(), out num1) && num1 > 0) break;
                else Console.WriteLine("Invalid input!");
            }
            while (true)
            {
                Console.Write("Enter the second number: ");
                if (Int32.TryParse(Console.ReadLine(), out num2) && num2 > 0) break;
                else Console.WriteLine("Invalid input!");
            }
            while (true)
            {
                Console.Write("Enter the second number: ");
                if (Int32.TryParse(Console.ReadLine(), out num3) && num3 > 0) break;
                else Console.WriteLine("Invalid input!");
            }
            originalNum1 = num1; 
            originalNum2 = num2;
            originalNum3 = num3;

            List<int> numsList = new List<int> { num1, num2, num3 };
            int index, gcd, lcm;
            
            gcd = findGCD(numsList[0], numsList[1]);
            lcm = (numsList[0] * numsList[1]) / gcd;
            index = 2;
            while (index < numsList.Count) {
                int prevGCD = gcd;
                int prevLCM = lcm;
                gcd = findGCD(prevGCD, numsList[index]);
                lcm = (prevLCM * numsList[index]) / gcd;
                index++;
            }
            Console.WriteLine($"\nThe GCD is {gcd}.");
            Console.WriteLine($"The LCM is {lcm}.");


            ///// FUNCTIONS /////
            int findGCD(int num1, int num2)
            {
                int num3 = num1 % num2;
                while (num3 != 0)
                {
                    num1 = num2;
                    num2 = num3;
                    num3 = num1 % num2;
                }
                return num2;
            }
        }
    }
}
