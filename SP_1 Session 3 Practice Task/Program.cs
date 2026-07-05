namespace SP_1_Session_3_Practice_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Task1:  Absolute Difference
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double differ = Math.Abs(num1 - num2);
            Console.WriteLine("The absolute difference between " +num1+" and "+num2+" is: "+differ);
            Console.WriteLine();
            */

            //Task2:   Power & Root Explorer
            Console.WriteLine("Enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The powor of " + number + " is: " + Math.Pow(number,2));
            Console.WriteLine("The square root of " + number + " is: " + Math.Sqrt(number));
            Console.WriteLine();


        }
    }
}
