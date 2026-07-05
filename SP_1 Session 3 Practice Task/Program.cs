using System.Data;

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
            

            //Task2:   Power & Root Explorer
            Console.WriteLine("Enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The powor of " + number + " is: " + Math.Pow(number,2));
            Console.WriteLine("The square root of " + number + " is: " + Math.Sqrt(number));
            Console.WriteLine();
            

            //Task3:   Name Formatter
            Console.WriteLine("Enter your full name: ");
            String fullName = Console.ReadLine();
            Console.WriteLine("Your name in uppercase is: " + fullName.ToUpper());
            Console.WriteLine("Your name in lowercase is: " + fullName.ToLower());
            Console.WriteLine("Your name has " + fullName.Length + " characters.");
            Console.WriteLine();
            

            //Task4:   Subscription End Date
            Console.WriteLine("Enter the number of days of a free trial: ");
            int freeTrialDays = Convert.ToInt32(Console.ReadLine());

            DateTime startData = DateTime.Today;

            DateTime endDate = startData .AddDays(freeTrialDays);

            Console.WriteLine("Trial end date: "+endDate.ToString("yyyy-MM-dd"));
            Console.WriteLine();

            
            //Task5:   Grade Rounding System
            Console.WriteLine("Enter raw exam score as a decimal number (e.g. 74.6): ");
            double score = Convert.ToDouble(Console.ReadLine());

            score = Math.Round(score, 0);
            Console.WriteLine("The rounded score is: " + score);
            if (score >= 60)
            {
                Console.WriteLine("Pass.");

            }
            else
            {
                Console.WriteLine("Fail.");
            }
            Console.WriteLine();

            

            //Task6:   Password Strength Checker
            Console.WriteLine("Enter a password: ");
            String password = Console.ReadLine().ToLower();
            int len = password.Length;
            bool contains = password.Contains("password");
            if (len >= 8)
            {
                if (contains)
                {
                    Console.WriteLine("Weak password: contains 'password'.");
                }
                else
                {
                    Console.WriteLine("Strong password: dont contains 'password'.");
                }
            }
            else
            {
                Console.WriteLine("Weak password: less than 8 characters.");
                

            }
            

            //Task7:   Clean Name Comparator
            Console.WriteLine("Enter a name: ");
            String name1 = Console.ReadLine().ToLower().Trim();
            Console.WriteLine("Enter the same name again: ");
            String name2 = Console.ReadLine().ToLower().Trim();

            if (name1 == name2)
            {
                Console.WriteLine("The names Matchs.");
            }
            else
            {
                Console.WriteLine("The names not match.");
            }
            

            //Task8:   Membership Expiry Checker
            Console.WriteLine("Enter your membership start date as text (e.g. \"2026-01-10\"): ");
            String input = Console.ReadLine();
            try
            {
                DateTime parsedDate = DateTime.Parse(input);

                Console.WriteLine("Enter number of valid membership days: ");

                int validDays = Convert.ToInt32(Console.ReadLine());

                
                DateTime exDate = parsedDate.AddDays(validDays);

                if (exDate >= DateTime.Today)
                {
                    Console.WriteLine("Membership is 'Active'");
                }
                else
                {
                    Console.WriteLine("Membership is 'Expired'");
                }
                Console.WriteLine("Expiry date: " + exDate.ToString("yyyy-MM-dd"));
            }
            catch 
            {
                Console.WriteLine("Invalid date format. Please enter the date in the correct format (e.g. \"2026-01-10\").");
            }
            */

            //Task9:   Round Up / Round Down Explorer
            Console.WriteLine("Enter a decimal number: ");
            float decimalNumber = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("The rounded value of " + decimalNumber + " is: " + Math.Round(decimalNumber));

            Console.WriteLine("The rounded up value of " + decimalNumber + " is: " + Math.Ceiling(decimalNumber));
            
            Console.WriteLine("The rounded down value of " + decimalNumber + " is: " + Math.Floor(decimalNumber));


        }
    }
}
