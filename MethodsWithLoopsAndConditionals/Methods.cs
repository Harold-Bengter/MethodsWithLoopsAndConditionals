using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals
{
    internal class Methods
    {
        public static void printOnek()
        {
            for (int A = 1000; A >= -1000; A--)
            {
                Console.WriteLine($"{A}");
            }
        }

        public static void EqualNotEqual()
        {

            Console.WriteLine("Let's see if your two numbers are equal.");

            Console.Write("Your first number:");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.Write("Your second number:");
            int num2 = Int32.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine($"Oh wow! Your two numbers {num1} and {num2} are equal!");
            }
            else
            {
                Console.WriteLine($"I'm sorry, {num1} and {num2} aren't equal");
            }
        }
        public static void print1kby3s()
        {
            for (int A = 3; A < 1000; A += 3)
            {
                Console.WriteLine(A);
            }
        }
        public static void EvenOrOdd()
        {
            Console.WriteLine("Enter your number to see if it's even or odd.");
            int B = Int32.Parse(Console.ReadLine());
             
            if (B % 2 == 0)
            {
                Console.WriteLine($"That number, {B} is even");
            }
            else
            {
                Console.WriteLine($"That number, {B} is odd.");
            }
        }
        public static void PlusOrMinus()
        {
            Console.WriteLine("Please enter a number to see if it's positive or negative");
            int C = Int32.Parse(Console.ReadLine());

            if (C > 0)
            {
                Console.WriteLine($"{C} is a positive number.");
            }
            else if (C < 0)
            {
                Console.WriteLine($"{C} is a negative number.");
            }
            else
                Console.WriteLine($"The number you enetered is zero.");
        }
        public static void VoteAge()
        {
            Console.WriteLine("Please enter your age to see if you're eligable to vote");
            int VoteAge = int.Parse(Console.ReadLine());

            if (VoteAge > 18)
            {
                Console.WriteLine($"Looks like you're {VoteAge}, You are eligible to vote");
            }
            else if (VoteAge < 18)
            {
                Console.WriteLine($"Looks like you're only {VoteAge}, You cannot vote.");
            }
            else
            {
                Console.WriteLine("Looks like you just turned 18! You can vote now");
            }
        }
        public static void MultiTable()
        {
            Console.WriteLine("Enter a number, 1 through 12, to see the multiplication table for your number");

            int D = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine($"{D} * {i} = {D * i}");
            }
        }
        public static void InRange()
        {
            Console.WriteLine("Please enter a number to see if it falls between -10 and 10");
            var YourNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(YourNumber <= 10 && YourNumber >= -10 ?
                $" Your number, {YourNumber}, fell between the range!" :
                $"Your number, {YourNumber}, did not fall between the range.");

        }
    }
}