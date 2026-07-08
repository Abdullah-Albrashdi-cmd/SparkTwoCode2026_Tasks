namespace SP_1_Session_5_Practice_Task_C__Fundamentals_Part_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

        }
    }
}
