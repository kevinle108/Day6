using System;
using System.Collections.Generic;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            List<int> numsList = new List<int> {};
            while (true)
            {
                Console.Write("Enter a positive integer: ");
                if (int.TryParse(Console.ReadLine(), out input) && input > 0)
                {
                    numsList.Add(input);
                } 
                else
                {
                    // prevents users from entering 0 when there is not enough numbers to find a GCD & LCM 
                    // need at least two values
                    if (input == 0 && numsList.Count >= 2) break; 
                    Console.WriteLine("Invalid input!");
                }
            }
            int index, gcd, lcm;
            gcd = findGCD(numsList[0], numsList[1]);
            lcm = (numsList[0] * numsList[1]) / gcd;
            index = 2;
            while (index < numsList.Count) 
            {
                int prevGCD = gcd;
                int prevLCM = lcm;
                gcd = findGCD(prevGCD, numsList[index]);
                lcm = (prevLCM * numsList[index]) / findGCD(prevLCM, numsList[index]);
                index++;
            }
            Console.WriteLine("Your numbers were: " + string.Join(", ", numsList) + ".");
            Console.WriteLine($"\nGCD = {gcd}.");
            Console.WriteLine($"LCM = {lcm}.");

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
