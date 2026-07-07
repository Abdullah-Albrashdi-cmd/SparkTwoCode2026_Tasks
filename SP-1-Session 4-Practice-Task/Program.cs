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
        static double CalculateArea1(double lenght, double width)
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

        //Task10
        static double CalculateArea(double sideOfSeq)
        {
            return sideOfSeq * sideOfSeq;
        }
        static double CalculateArea(double a, double b)
        {
            return a*b;
        }

        //Task11
        static double Add(double a, double b)
        {
            return a + b;
        }
        static double Subtract(double a, double b)
        {
            return a - b;
        }
        static double MultiplyNumbers(double a, double b)
        {
            return a * b;
        }
        static double DivideNumbers(double a, double b)
        {
            try
            {
                double d = a / b;
                return d;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return 0;
            }
        }
        static void DisplayResult(string opname, double reselt)
        {
            Console.WriteLine("The reselt of the " + opname + " is: " + reselt);
        }


        //Task12





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

            double area = CalculateArea1(length, Width);
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




            //Task 10
            Console.WriteLine("Which shape do you want to calculate the area of?");
            Console.WriteLine("1.Squarer");
            Console.WriteLine("2.Rectangle");
            Console.WriteLine("Enter your choice (1/2): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enrt the side length: ");
                double sideLen = Convert.ToInt32(Console.ReadLine());
                double area1 = CalculateArea(sideLen);
                Console.WriteLine("The area of the Square is: " + area1);

            }
            else if (choice == 2)
            {
                Console.WriteLine("Enrt the length: ");
                double length1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enrt the width: ");
                double wedth1 = Convert.ToInt32(Console.ReadLine());

                double area2 = CalculateArea(length1,wedth1);
                Console.WriteLine("The area of the Rectangle is: " + area2);
            }
            Console.WriteLine();


            //Task11
            while(true)
                {
                    Console.WriteLine("Choose an operation:");
                    Console.WriteLine("1.Add");
                    Console.WriteLine("2.Subtract");
                    Console.WriteLine("3.Multiply");
                    Console.WriteLine("4.Divide");
                    Console.WriteLine("5.Exit");

                    int op = Convert.ToInt32(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            Console.WriteLine("Enter two numbers to add: ");
                            double a1 = Convert.ToDouble(Console.ReadLine());
                            double b1 = Convert.ToDouble(Console.ReadLine());
                            double res1 = Add(a1, b1);
                            DisplayResult("Addition", res1);
                            break;

                        case 2:
                            Console.WriteLine("Enter two numbers to subtract: ");
                            double a2 = Convert.ToDouble(Console.ReadLine());
                            double b2 = Convert.ToDouble(Console.ReadLine());
                            double reslt2 = Subtract(a2, b2);
                            DisplayResult("Subtraction", reslt2);
                            break;

                        case 3:
                            Console.WriteLine("Enter two numbers to multiply: ");
                            double a3 = Convert.ToDouble(Console.ReadLine());
                            double b3 = Convert.ToDouble(Console.ReadLine());
                            double reslt3 = MultiplyNumbers(a3, b3);
                            DisplayResult("Multiplication", reslt3);
                            break;

                        case 4:
                            Console.WriteLine("Enter two numbers to divide: ");
                            double a4 = Convert.ToDouble(Console.ReadLine());
                            double b4 = Convert.ToDouble(Console.ReadLine());
                            double reslt4 = DivideNumbers(a4, b4);
                            DisplayResult("Division", reslt4);
                            break;

                        case 5:

                            Console.WriteLine("Exiting the program.");
                            return;
                    }

                    Console.WriteLine();
                }




            //Task12





        }
    }
}
