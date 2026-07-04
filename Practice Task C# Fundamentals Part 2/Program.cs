using System.ComponentModel;
using System.Security.AccessControl;

namespace Practice_Task_C__Fundamentals_Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
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
            Console.WriteLine($"The sum of numbers from 1 to" +n +" is: "+sum);
            Console.WriteLine();
            

            //Task3:  Multiplication Table
            Console.WriteLine("Enter a number to generate its multiplication table: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine( num+ "x" +i+ "=" +(num * i));
            }
            Console.WriteLine() ;

            
            //Task4:   Password Retry
            string correctPassword = "Spark2026";
            Console.WriteLine("Enter the password: ");
            String userInput = Console.ReadLine();

            while (userInput != correctPassword)
            {
                Console.WriteLine("Incorrect password, try again");
                userInput = Console.ReadLine();
            }
            Console.WriteLine("Access granted!");
            Console.WriteLine();
            

            //Task5:   Number Guessing Game
            int secretNumber = 27;
            int userGuess;
            int counter = 0;
            do {
                Console.WriteLine("Guess the secret number between 1 and 50: ");
                userGuess = Convert.ToInt32(Console.ReadLine());
                counter++;

                if (userGuess < secretNumber)
                {
                    Console.WriteLine("Too low.");
                }
                else if (userGuess > secretNumber)
                {
                    Console.WriteLine("Too high.");
                }
                else
                {
                    Console.WriteLine("Correct! You guessed the secret number "+secretNumber+" in "+counter+" attempts.");
                }

            } while (userGuess != secretNumber);
            Console.WriteLine();
            

            //task6:   Safe Division Calculator
            try
            {
                Console.WriteLine("Enter the first number (numerator): ");
                int numerator = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the second number (denominator): ");
                int denominator = Convert.ToInt32(Console.ReadLine());

                int result = numerator / denominator;
                Console.WriteLine("The result of the division is: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero. Please try again with a non zero denominator.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid whole numbers only.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }

            Console.WriteLine();

            

            //Task7:    Repeating Menu with Exit Option
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("----- MENU -----");
                Console.WriteLine("1) Say Hello");
                Console.WriteLine("2) Show Time-of-day Greeting");
                Console.WriteLine("3) Exit");
                Console.WriteLine("Enter your choice: ");

                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Hello!");
                            break;
                        case 2:
                            Console.WriteLine("Good day, Hope you're having a great time.");
                            break;
                        case 3:
                            Console.WriteLine("Exiting the program. See You");
                            isRunning = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice, please select 1, 2, or 3.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Please enter a valid number (1, 2, or 3).");
                }

                Console.WriteLine();
            }
            */

            //Task8:    Sum of Even Numbers Only
            Console.WriteLine("Enter a positive whole number N: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int total = 0;

            for (int i = 1; i <= n2; i++)
            {
                if (i % 2 == 0)
                {
                    total += i;
                }
            }
            Console.WriteLine("The final sum of even numbers from 1 to "+n2+" is: "+total);
            Console.WriteLine();






        }
    }
}
