namespace SP_1_Session_4_Practice_Task
{
    internal class Program
    {
        //Task1
        static void PrintWelcome(string name)
        {
            Console.WriteLine("Welcome " + name + " We're happy to have you here.");
        } 

        //Task2
        static int SQUARE(int number)
        {
            return number * number;            
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
            



        }
    }
}
