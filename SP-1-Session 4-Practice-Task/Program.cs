using System.Xml.Serialization;

namespace SP_1_Session_4_Practice_Task
{
    internal class Program
    {
        //Task1
        static void PrintWelcome(string name)
        {
            Console.WriteLine("Welcome " + name + " We're happy to have you here.");
            Console.WriteLine();
        } 

        //Task2
        static int SQUARE(int number)
        {
            return number * number;            
        }

        //Task3
        static double CelsiusToFahrenheit(double celsius)
        {
            double F = (celsius * 9 / 5) + 32;
            return F;
        }

        //Task4
        static void DisplayMenu(string name)
        {
            Console.WriteLine("OPTION MENU");
            Console.WriteLine("1.Start");
            Console.WriteLine("2.Help");
            Console.WriteLine("3.Exit");
        }

        //Task5
        static bool IsEven(int number)
        {
            return (number % 2 == 0);
        }

        //Task6
        static double CalculateArea(double lenght, double width)
        {
            return  (lenght * width);
        }

        static double CalculatePerimeter(double lenght, double width)
        {
            return (2 * (lenght + width));
        }

        //Task7
        static string GetGradeLetter(int score)
        {
            string grade = "";

            if (score >= 90 && score <=100)
            {
                grade = "A";
            }
            else if (score >= 80)
            {
                grade = "B";
            }
            else if (score >= 70)
            {
               grade = "C";
            }
            else if (score >= 60)
            {
                grade = "D";
            }
            else if (score >= 0)
            {
                grade = "F";
            }
            else
            {
                grade = "Not a Valid score enterd";
            }

            return grade;
        }

        //Task8
        static void Countdown(int num)
        {
            for (int i = num; i >0; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Task9
        static int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }
        static double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }
        static int Multiply(int n1, int n2, int n3)
        {
            return n1 * n2 * n3;
        }





        static void Main(string[] args)
        {
            //Task1
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            PrintWelcome(userName);


            //Task2
            Console.WriteLine("Enter an interger number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int reselt = SQUARE(number);
            Console.WriteLine("The Square of " + number + " is: " + reselt);
            Console.WriteLine();


            //Task3 
            Console.WriteLine("Entyer temp on Celisus: ");
            double cel = Convert.ToDouble(Console.ReadLine());

            double fah = CelsiusToFahrenheit(cel);

            Console.WriteLine("The temp on Fahrenheit is: " + fah);
            Console.WriteLine();


            //Task4
            {
                DisplayMenu(userName);
                Console.WriteLine();
            }


            //Task5
            Console.WriteLine("Enter a number to check if its (even/odd): ");
            int num = Convert.ToInt32(Console.ReadLine());

            bool reselt1 = IsEven(num);

            if (reselt1)
            {
                Console.WriteLine("The number is even.");

            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
            Console.WriteLine();


            //Task6
            Console.WriteLine("Enter the Length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Widht: ");
            double Width = Convert.ToDouble(Console.ReadLine());

            double area = CalculateArea(length, Width);
            double param = CalculatePerimeter(length, Width);

            Console.WriteLine("The area os the Rectangle is: "+area);
            Console.WriteLine("The Perimeter os the Rectangle is: " + param);
            Console.WriteLine();



            //Task7
            Console.WriteLine("Enter your score to see your garde: ");
            int score = Convert.ToInt32(Console.ReadLine());

            string grade = GetGradeLetter(score);

            Console.WriteLine("Your garde is: "+grade);
            Console.WriteLine();



            //Task8
            Console.WriteLine("Enter an integer number to count down from the num to 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Countdown(num1);
            Console.WriteLine();




            //Task9
            int n1 = 3;
            int n2 = 6;
            int n3 = 7;
            double n4 = 5.2;
            double n5 = 2.8;

            Console.WriteLine("The reselt of calling Multiply(with two intger parameters is: " + Multiply(n1, n2));
            Console.WriteLine("The reselt of calling Multiply(with two double parameters is: " + Multiply(n4, n5));
            Console.WriteLine("The reselt of calling Multiply(with three intger parameters is: " + Multiply(n2, n3));
            Console.WriteLine();









        }
    }
}
