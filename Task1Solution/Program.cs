using System.ComponentModel.Design;
using System.Data.Common;
using System.Formats.Asn1;

namespace Task1Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {

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
        }

    }
}