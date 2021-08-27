using System;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int thirdNumber = 0;
            int result = 0;

            // first number
            Console.Write("Please enter the first number: ");
            firstNumber = int.Parse(Console.ReadLine());

            // second number
            Console.Write("Please enter the second number: ");
            secondNumber = int.Parse(Console.ReadLine());

            // third number
            Console.Write("Please enter the third number: ");
            thirdNumber = int.Parse(Console.ReadLine());

            // Task 1 - Multiplication
            result = firstNumber * secondNumber * thirdNumber;
            Console.WriteLine("The answer is: " + result);


        }
    }
}
