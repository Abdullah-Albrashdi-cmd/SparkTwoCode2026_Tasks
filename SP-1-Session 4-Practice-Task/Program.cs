namespace SP_1_Session_4_Practice_Task
{
    internal class Program
    {
        static void PrintWelcome(string name)
        {
            Console.WriteLine("Welcome " + name + " We're happy to have you here.");
        }

        
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            PrintWelcome(userName);
        }
    }
}
