namespace SP_1_Session_5_Practice_Task_C__Fundamentals_Part_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            //Task1: Fixed Grades Array
            int[] garde = new int[5];
            for (int i = 0; i < garde.Length; i++) 
            {
                Console.WriteLine("Enter the grase: ");
                garde[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int i in garde)
            {
                Console.WriteLine("The grades are: ");
                Console.WriteLine(i);
                Console.WriteLine();
            }


            //Task2: Dynamic To-Do List
            List<string> list = new List<string>();
            for (int i = 0;i < 5;i++)
            {
                Console.WriteLine("Enter task: ");
                string input = Console.ReadLine();
                list.Add(input);

            }
            Console.WriteLine("The tasks are: ");
            foreach (string input in list)
            {
                Console.WriteLine(input);
            }
            Console.WriteLine();


            //Task3: Browsing History stack
            Stack<string> history = new Stack<string>();

            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Enter website URL " + i + ": ");
                string url = Console.ReadLine();
                history.Push(url);
            }

            Console.WriteLine("Current page: " + history.Peek());

            Console.WriteLine("Pressing back button ");
            string previousPage = history.Pop();

            Console.WriteLine("You went back from: " + previousPage);
            Console.WriteLine("You are now on: " + history.Peek());
            Console.WriteLine();
            */


            //Task4: Customer Service Queue
            Queue<string> customQu = new Queue<string>();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Enter Customer " + i + " name:");
                string name = Console.ReadLine();
                customQu.Enqueue(name);
            }
            string name1 = customQu.Dequeue();
            Console.WriteLine("Now serving: " + name1);




        }
    }
}
