using System.ComponentModel.Design;
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
                "name: "+name+". Age: "+age+". Height: "+height+". Student: "+isStudent);


            //2:Task 2 - Rectangle Calculator
            Console.WriteLine("Enter the length of the rectangle: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the width of the rectangle: ");
            int width = Convert.ToInt32(Console.ReadLine());

            int Area = length * width;

            Console.WriteLine("The Length of the rectangle is: " + length);
            Console.WriteLine("The Width of the rectangle is: " + width);
            Console.WriteLine("The area of the rectangle is: " + Area);


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
            */


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
        }
    }
}
