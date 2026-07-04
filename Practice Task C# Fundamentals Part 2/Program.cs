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
            bool isRunningg = true;

            while (isRunningg)
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
                            isRunningg = false;
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

        

            //Task9:    Validated Positive Number Input
            int number1 = 0;
            bool isValid = false;

            do
            {
                try
                {
                    Console.WriteLine("Enter a positive whole number: ");
                    number1 = Convert.ToInt32(Console.ReadLine());

                    if (number1 <= 0)
                    {
                        Console.WriteLine("Error: Please enter a number greater than zero.");
                    }
                    else
                    {
                        isValid = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Please enter a valid whole number.");
                }

            } while (!isValid);

            int sum1 = 0;
            for (int i = 1; i <= number1; i++)
            {
                sum1 += i;
            }

            Console.WriteLine("The sum of all whole numbers from 1 to " + number1 + " is: " + sum1);
            Console.WriteLine();

            */
            //Task10:    Simple ATM Simulation
            int correctPin = 2244;
            double balance = 100.000;
            int attempts = 0;
            bool pinCorrect = false;

            while (attempts < 3 && !pinCorrect)
            {
                try
                {
                    Console.WriteLine("Enter your PIN: ");
                    int enteredPin = Convert.ToInt32(Console.ReadLine());

                    if (enteredPin == correctPin)
                    {
                        pinCorrect = true;
                    }
                    else
                    {
                        attempts++;
                        Console.WriteLine("Incorrect PIN. Attempts remaining: " + (3 - attempts));
                    }
                }
                catch (FormatException)
                {
                    attempts++;
                    Console.WriteLine("Invalid input. Attempts remaining: " + (3 - attempts));
                }
            }

            if (!pinCorrect)
            {
                Console.WriteLine("Card Blocked");
            }
            else
            {
                Console.WriteLine("PIN accepted. Welcome!");
                bool isRunning = true;

                while (isRunning)
                {
                    Console.WriteLine("--ATM MENU--");
                    Console.WriteLine("1) Deposit");
                    Console.WriteLine("2) Withdraw");
                    Console.WriteLine("3) Check Balance");
                    Console.WriteLine("4) Exit");
                    Console.WriteLine();
                    Console.WriteLine("Enter your choice: ");
                    
                    try
                    {
                        int choice = Convert.ToInt32(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                try
                                {
                                    Console.WriteLine("Enter deposit amount: ");
                                    double depositAmount = Convert.ToDouble(Console.ReadLine());

                                    if (depositAmount <= 0)
                                    {
                                        Console.WriteLine("Error: Deposit amount must be positive.");
                                    }
                                    else
                                    {
                                        balance += depositAmount;
                                        Console.WriteLine("Deposit successful. New balance: " + balance + " OMR");
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Error: Please enter a valid number.");
                                }
                                break;

                            case 2:
                                try
                                {
                                    Console.WriteLine("Enter withdrawal amount: ");
                                    double withdrawAmount = Convert.ToDouble(Console.ReadLine());

                                    if (withdrawAmount <= 0)
                                    {
                                        Console.WriteLine("Error: Withdrawal amount must be positive.");
                                    }
                                    else if (withdrawAmount > balance)
                                    {
                                        Console.WriteLine("Error: Insufficient balance.");
                                    }
                                    else
                                    {
                                        balance -= withdrawAmount;
                                        Console.WriteLine("Withdrawal successful. New balance: " + balance + " OMR");
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Error: Please enter a valid number.");
                                }
                                break;

                            case 3:
                                Console.WriteLine("Current balance: " + balance + " OMR");
                                break;

                            case 4:
                                Console.WriteLine("Thank you for using the ATM.");
                                isRunning = false;
                                break;

                            default:
                                Console.WriteLine("Invalid choice, please select 1-4.");
                                break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: Please enter a valid number for the menu choice.");
                    }

                    Console.WriteLine();
                }
            }



        }
    }
}
