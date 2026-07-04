namespace Practice_Task_C__Fundamentals_Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1: Countdown Timer

            Console.WriteLine("Enter a starting number: ");
            int startNum = Convert.ToInt32(Console.ReadLine());

            for (int i = startNum; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Liftoff!");
            Console.WriteLine();
        }
    }
}
