namespace Task1Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //1:
            Console.WriteLine("Enter: ");
            object obj = Console.ReadLine();
            Console.WriteLine("He" + obj);

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are " + age + " years old.");

            for (int i=0; i<=5; i++)
            {
                Console.WriteLine(i);
            }
            */
            string[] fr = { "Apple", "Banana", "Cherry" };
            foreach (string fruit in fr)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
