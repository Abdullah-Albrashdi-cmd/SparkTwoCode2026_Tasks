namespace C__Fundamentals___Mini_Compound_Project
{
    internal class Program
    {
        // Shared data storage - declared at class level (static) so that
        // EVERY function below can read and modify the same three lists
        // without needing them passed in as parameters.
        static List<string> customerNames = new List<string>();
        static List<double> accountNumbers = new List<double>();
        static List<double> balances = new List<double>();
        static void Main(string[] args)
        {
            bool exitApp = false;
            while (!exitApp)
            {
                Console.WriteLine("\n===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. <your 1st custom service - choose a name>");
                Console.WriteLine("7. <your 2nd custom service - choose a name>");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");
                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                    continue; // skip the rest of this loop pass, show the menu again
                }
                switch (choice)
                {
                    case 1:
                        AddAccount();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        ShowBalance();
                        break;
                    case 5:
                        TransferAmount();
                        break;
                    case 6:
                        // TODO: call your first custom service function here
                        break;
                    case 7:
                        // TODO: call your second custom service function here
                        break;
                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for banking with Spark Bank. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 8.");
                        break;
                }
            }
        }
        // ===================== SERVICE FUNCTIONS =====================
        // Each function owns ONE service end-to-end: it asks the user for
        // whatever it needs, validates it, updates the shared lists, and
        // prints the outcome. Main never reads input or prints results
        // for these services - it only shows the menu and calls them.
        static void AddAccount()
        {
            // TODO: implement this service (see Section 3 requirements)

            Console.WriteLine("Enter your Name: ");
            string name = Console.ReadLine();
            foreach (string item in customerNames)
            {
                if (item.Contains(name))
                {
                    Console.WriteLine("The entered name is exist, Enter another name: ");
                    name = Console.ReadLine();
                }
            }
            customerNames.Add(name);
            Console.WriteLine("Enter your new account number: ");
            double accountNum = Convert.ToDouble(Console.ReadLine());

            foreach (double item in accountNumbers)
            {
                if (item  == accountNum)
                {
                    Console.WriteLine("The entered Account number is exist, Enter another one:");
                    accountNum = Convert.ToDouble(Console.ReadLine());
                }
            }
            accountNumbers.Add(accountNum);
            Console.WriteLine("Enter the initial deposit amount (not negative): ");
            double amount = Convert.ToDouble(Console.ReadLine());
            foreach (double item in balances)
            {
                if (amount <0)
                {
                    Console.WriteLine("The entered amount is negative, Enter another one:");
                    amount = Convert.ToDouble(Console.ReadLine());
                }
            }
            balances.Add(amount);





        }
        static void DepositMoney()
        {
            // TODO: implement this service (see Section 3 requirements)
        }
        static void WithdrawMoney()
        {
            // TODO: implement this service (see Section 3 requirements)
        }
        static void ShowBalance()
        {
            // TODO: implement this service (see Section 3 requirements)
        }
        static void TransferAmount()
        {
            // TODO: implement this service (see Section 3 requirements)
        }
        // TODO: write two more void, no-parameter functions here for
        // your own custom services (option 6 and option 7)
    }
}
