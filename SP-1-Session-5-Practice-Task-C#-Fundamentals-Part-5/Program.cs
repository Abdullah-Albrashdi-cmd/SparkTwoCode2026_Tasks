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
            Console.WriteLine();
            


            //Task5: Array Grade Range
            int[] grade1 = new int[5];

            for (int i = 0; i < grade1.Length; i++)
            {
                Console.WriteLine("Enter the grade: ");
                grade1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(grade1);
            Console.WriteLine("The lowest grade is: " + grade1[0]);
            Console.WriteLine();
            


            //Task6: Filtered Shopping List
            List<string> shoppingList = new List<string>();

            string done = "";

            while (done != "done")
            {
                Console.WriteLine("Enter an item (or type 'done' to finish):");
                string item = Console.ReadLine();
                if (item.ToLower() == "done")
                {
                    done = "done";
                }
                else
                {
                    shoppingList.Add(item);
                }
            }
            Console.WriteLine("The List befor removing an item is: ");
            foreach (string item in shoppingList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Enter item name to remove: ");
            string removeItem = Console.ReadLine();
            shoppingList.Remove(removeItem);

            Console.WriteLine("The List after removing an item is: ");

            foreach (string item in shoppingList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            */



            //Task7: high score podium
            List<int> scores = new List<int>();

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Enter game score " + i + ":");
                int score = Convert.ToInt32(Console.ReadLine());
                scores.Add(score);
            }
            scores.Sort();
            scores.Reverse();

            Console.WriteLine("1st place: " + scores[0]);
            Console.WriteLine("2nd place: " + scores[1]);
            Console.WriteLine("3rd place: " + scores[2]);
            Console.WriteLine();


        }
    }
}
