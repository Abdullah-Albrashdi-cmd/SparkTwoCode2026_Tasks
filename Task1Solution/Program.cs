using System.ComponentModel.Design;
using System.Data.Common;
using System.Formats.Asn1;

namespace Task1Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //1:Task 1 - Personal Info Card
            string name = "Ali Ahmed";
            int age = 22;
            double height = 1.71;
            bool isStudent = true;

            Console.WriteLine(
                "name: " + name + ". Age: " + age + ". Height: " + height + ". Student: " + isStudent);
            Console.WriteLine();

            //2:Task 2 - Rectangle Calculator
            Console.WriteLine("Enter the length of the rectangle: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the width of the rectangle: ");
            int width = Convert.ToInt32(Console.ReadLine());

            int Area = length * width;

            Console.WriteLine("The Length of the rectangle is: " + length);
            Console.WriteLine("The Width of the rectangle is: " + width);
            Console.WriteLine("The area of the rectangle is: " + Area);
            Console.WriteLine();

            //3:Task 3 -  Even or Odd Checker
            Console.WriteLine("Enter a number to check if it is even or odd: ");
            double number = Convert.ToDouble(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number " + number + " is even.");
            }
            else
            {
                Console.WriteLine("The number " + number + " is odd.");
            }
            Console.WriteLine();


            //4:Task 4 -  Voting Eligibility

            Console.WriteLine("Enter your age to check if you are eligible to vote: ");
            int userAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you have a valid ID? (yes/no): ");
            string hasValidID = Console.ReadLine();

            bool hasValidId = (hasValidID == "yes");


            if (hasValidId && userAge >= 18)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }
            Console.WriteLine();

            //5:Task 5 -  Grade Letter Lookup
            Console.WriteLine("Enter your grade (A, B, C, D, F): ");

            char grade = Console.ReadLine().ToUpper()[0];

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;
                case 'B':
                    Console.WriteLine("Good job!");
                    break;
                case 'C':
                    Console.WriteLine("Good.");
                    break;
                case 'D':
                    Console.WriteLine("Pass.");
                    break;
                case 'F':
                    Console.WriteLine("Fail.");
                    break;
                default:
                    Console.WriteLine("Invalid grade entered.");
                    break;

            }
            Console.WriteLine();


            //6:Task 6 -   Temperature Converter

            Console.WriteLine("Enter the temperature in Celsius: ");

            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;

            String Classification = "";

            if (fahrenheit < 10)
            {
                Classification = "Cold";
            }
            if (fahrenheit >= 10 && fahrenheit <= 30)
            {
                Classification = "Mild";
            }
            else if (fahrenheit > 30)
            {
                Classification = "Hot";
            }

            Console.WriteLine("The Temperature in Fahrenheit is: " + fahrenheit);
            Console.WriteLine("The Weather classification is: " + Classification);
            Console.WriteLine();


            //7:Task 7 -   Movie Ticket Pricing
            Console.WriteLine("Enter your age to check the movie ticket price: ");
            int tAge = Convert.ToInt32(Console.ReadLine());

            double ticketPrice = 0;
            String category = "";

            if (tAge >= 0 && tAge <= 12)
            {
                ticketPrice = 2.000;
                category = "Child";
            }
            else if (tAge >= 13 && tAge <= 59)
            {
                ticketPrice = 5.000;
                category = "Adult";
            }
            else if (tAge >= 60)
            {
                ticketPrice = 3.000;
                category = "Senior";
            }
            else
            {
                Console.WriteLine("Invalid age entered.");
            }
            Console.WriteLine("The movie ticket price for " + category + " is: " + ticketPrice + " OMR");
            Console.WriteLine();


            //8:Task 8 -    Restaurant Bill with Membership Discount
            Console.WriteLine("Enter the total bill amount: ");
            double billAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Are you a member? (yes/no): ");
            string isMemberInput = Console.ReadLine().ToLower();
            bool isMember = (isMemberInput == "yes");
            String discount = "";
            double finalAmount = 0;

            if (billAmount > 20 && isMember)
            {
                discount = "15%";
                finalAmount = billAmount - billAmount * 0.15;

            }
            else
            {
                discount = "no discount";
                finalAmount = billAmount;
            }
            Console.WriteLine();
            Console.WriteLine("The original bill amount is: " + billAmount + " OMR");
            Console.WriteLine("The discount applied is: " + discount);
            Console.WriteLine("The final bill amount is: " + finalAmount + " OMR");
            Console.WriteLine();


            //9:Task 9 -    Day Name Finder
            Console.WriteLine("Enter a number (1-7) to find the corresponding day of the week: ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("The day is Sunday.");
                    break;
                case 2:
                    Console.WriteLine("The day is Monday.");
                    break;
                case 3:
                    Console.WriteLine("The day is Tuesday.");
                    break;
                case 4:
                    Console.WriteLine("The day is Wednesday.");
                    break;
                case 5:
                    Console.WriteLine("The day is Thursday.");
                    break;
                case 6:
                    Console.WriteLine("The day is Friday.");
                    break;
                case 7:
                    Console.WriteLine("The day is Saturday.");
                    break;
                default:
                    Console.WriteLine("Invalid day number entered.");
                    break;

            }
            Console.WriteLine();

            
            //10:Task 10 -   Mini Calculator
            Console.WriteLine("Enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operation (+, -, *, /): ");
            char operation = Console.ReadLine()[0];

                switch (operation)
                {
                    case '+':
                        Console.WriteLine("The result of addition is: " + (firstNumber + secondNumber));
                        break;
                    case '-':
                        Console.WriteLine("The result of subtraction is: " + (firstNumber - secondNumber));
                        break;
                    case '*':
                        Console.WriteLine("The result of multiplication is: " + (firstNumber * secondNumber));
                        break;
                    case '/':
                        if (secondNumber != 0)
                        {
                            Console.WriteLine("The result of division is: " + (firstNumber / secondNumber));
                        }
                        else
                        {
                            Console.WriteLine("Cannot divide by zero.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation entered.");
                        break;
                }
            Console.WriteLine();

            */
            //11:Task 11 -   Loan Eligibility System

            Console.WriteLine("Enter your Age: ");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your monthly income: ");
            double monthlyIncome = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Did you have an existing loan (yes/no): ");
            String haveLone = Console.ReadLine().ToLower();
            bool haveExLone = (haveLone == "yes");

            if (userAge>=21 && userAge<=60 && monthlyIncome>=400 && !haveExLone)
            {
                Console.WriteLine("User are eligible.");
            }
            else if (userAge <21 || userAge>60)
            {
                Console.WriteLine("User are not eligible 'age out of range'.");
            }
            else if (monthlyIncome < 400)
            {
                Console.WriteLine("User are not eligible 'Income too low.'");
            }
            else
            {
                if (haveExLone) {
                    Console.WriteLine("User are not eligible 'User has an existing loan.'");
                }
            }
            Console.WriteLine();

        }

    }

}