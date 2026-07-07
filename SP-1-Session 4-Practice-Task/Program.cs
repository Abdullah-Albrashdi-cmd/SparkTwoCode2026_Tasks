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
            }


            

        }
    }
}
