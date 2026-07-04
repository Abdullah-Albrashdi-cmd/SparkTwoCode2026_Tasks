using System.Security.AccessControl;

namespace Practice_Task_C__Fundamentals_Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1: Countdown Timer

            Console.WriteLine("Enter a starting number: ");
            int startNum = Convert.ToInt32(Console.ReadLine());

            for (int i = startNum; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Liftoff!");
            Console.WriteLine();


            //Task2:  Sum of Numbers 1 to N

            Console.WriteLine("Enter a positive whole number N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine($"The sum of numbers from 1 to {n} is: {sum}");

        }
    }
}
