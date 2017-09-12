using System;

namespace SimpleAddition
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the first number you would like to add: ");
            int num1;

            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number you would like to add: ");
            int num2;

            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The sum of those numbers is: " + (num1 + num2));
        }
    }
}
