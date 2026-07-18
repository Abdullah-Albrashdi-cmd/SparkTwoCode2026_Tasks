namespace SP_2_OOP_Part_1
{
    internal class Program
    {
        class BankAccount
        {

            public int AccountNumber { get; set; }
            public string HolderName { get; set; }
            public double Balance { get; set; }

            public void Deposit(double amount)
            {
                Balance += amount;
                SendEmail();
            }

            public void Withdraw(double amount)
            {
                if (Balance >= amount)
                {
                    Balance -= amount;
                }
                SendEmail();
            }

            public double CheckBalance()
            {
                PrintInformation();
                return Balance;
            }

            private void PrintInformation()
            {
                Console.WriteLine("Holder Name: " + HolderName);
                Console.WriteLine("Balance: " + Balance);
            }

            private void SendEmail()
            {
                Console.WriteLine("Email sent to " + HolderName );
            }
        }

        class Student
        {
            public int Grade;
            public string Name;
            public string Address;
            private string email;
            private int age;

            public Student(string name, string adds, int grade) 
            {
                Name = name;
                Address = adds;
                Grade = grade;

            }

            
            public void Register(string Email)
            {
                email = Email;
                SendEmail();

            }

            private void SendEmail()
            {
                Console.WriteLine("Registration email sent to " + Name);
            }
        }
        class Product
        {
            public string ProductName;
            public double Price;
            public int StockQuantity;

            public void Sell(int quantity)
            {
                if (StockQuantity < quantity)
                {
                    StockQuantity -= quantity;

                }
                else
                {
                    Console.WriteLine("not enough stock");
                }
                LogTransaction();
            }

            public void Restock(int quantity)
            {
                StockQuantity += quantity;
                LogTransaction();
            }

            public double GetInventoryValue()
            {
                PrintDetails();
                return Price * StockQuantity;
            }

            private void PrintDetails()
            {
                Console.WriteLine("Product Name: " + ProductName);
                Console.WriteLine("Price: " + Price);
                Console.WriteLine("Stock Quantity: " + StockQuantity);
                
            }

            private void LogTransaction()
            {
                Console.WriteLine("Transaction being logged for "+ProductName);
            }
        }




        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount();
            account1.AccountNumber = 1163;
            account1.HolderName = "karim";
            account1.Balance = 120;

            BankAccount account2 = new BankAccount();
            account2.AccountNumber = 15203;
            account2.HolderName = "Ali";
            account2.Balance = 63;

            Student student1 = new Student("Ali", "Muscat", 65);
            Student student2 = new Student("Ahmed", "Muscat", 70);

            Product product1 = new Product();
            product1.ProductName = "Wireless Mouse";
            product1.Price = 5.500;
            product1.StockQuantity = 50;

            Product product2 = new Product();
            product2.ProductName = "Mechanical Keyboard";
            product2.Price = 15.750;
            product2.StockQuantity = 20;

            bool running = true;

            while (running)
            {
                PrintMenu();

                int choice = GetIntInput("Enter your choice: ");


                switch (choice)
                {
                    case 1:
                        Case1ViewAccountDetails(account1, account2);
                        break;
                    case 2:
                        Case2UpdateStudentAddress(student1, student2);
                        break;
                    case 3:
                        Case3MakeDeposit(account1, account2);
                        break;
                    case 4:
                        Case4MakeWithdrawal(account1, account2);
                        break;
                    case 5:
                        Case5ViewProductDetails(product1, product2);
                        break;
                    case 6:
                        Case6RegisterStudent(student1, student2);
                        break;
                    case 7:
                        Case7CompareBalances(account1, account2);
                        break;
                    case 8:
                        Case8RestockProduct(product1, product2);
                        break;
                    case 9:
                        Case9TransferBetweenAccounts(account1, account2);
                        break;
                    case 10:
                        Case10UpdateStudentGrade(student1, student2);
                        break;
                    case 11:
                        Case11StudentReportCard(student1, student2);
                        break;
                    case 12:
                        Case12AccountHealthStatus(account1, account2);
                        break;
                    case 13:
                        Case13BulkSale(product1, product2);
                        break;
                    case 14:
                        Case14ScholarshipEligibility(student1, student2, account1, account2);
                        break;
                    case 15:
                        Case15FullBalanceTopUp(account1, account2);
                        break;
                    case 16:
                        Case16QuickAccountOpening();
                        break;
                    case 17:
                        Case17TotalStudentsCounter();
                        break;
                    case 18:
                        Case18OverdrawnAccountCheck(account1, account2);
                        break;
                    case 19:
                        Case19SetStudentPin(student1, student2);
                        break;
                    case 20:
                        running = false;
                        Console.WriteLine("Thank you");
                        break;
                    default:
                        Console.WriteLine("Invalid choice pick a number between 1 and 20");
                        break;
                }

                Console.WriteLine();
            }
            

            static void PrintMenu()
            {
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine(" 1. View Account Details");
                Console.WriteLine(" 2. Update Student Address");
                Console.WriteLine(" 3. Make a Deposit");
                Console.WriteLine(" 4. Make a Withdrawal");
                Console.WriteLine(" 5. View Product Details");
                Console.WriteLine(" 6. Register a Student");
                Console.WriteLine(" 7. Compare Two Account Balances");
                Console.WriteLine(" 8. Restock Product & Stock Level Check");
                Console.WriteLine(" 9. Transfer Between Accounts");
                Console.WriteLine("10. Update Student Grade ");
                Console.WriteLine("11. Student Report Card");
                Console.WriteLine("12. Account Health Status");
                Console.WriteLine("13. Bulk Sale With Revenue Calculation");
                Console.WriteLine("14. Scholarship Eligibility Check");
                Console.WriteLine("15. Full Balance ");
                Console.WriteLine("16. Quick Account Opening ");
                Console.WriteLine("17. Total Students Counter");
                Console.WriteLine("18. Overdrawn Account Check");
                Console.WriteLine("19. Set Student Security PIN");
                Console.WriteLine("20. Exit");
                Console.WriteLine("----------------------------------------------------");
            }

            //Input functions

            static int GetIntInput(string prompt)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                int result;
                bool success = int.TryParse(input, out result);
                if (!success)
                {
                    Console.WriteLine("not a valid whole number");
                    return -1;
                }
                return result;
            }

            static double GetDoubleInput(string prompt)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                double result;
                bool success = double.TryParse(input, out result);
                if (!success)
                {
                    Console.WriteLine("not a valid number");
                    return -1;
                }
                return result;
            }

            static string GetStringInput(string prompt)
            {
                Console.Write(prompt);
                return Console.ReadLine();
            }

            //Chooses functions

            static BankAccount ChooseAccount(BankAccount account1, BankAccount account2)
            {
                Console.WriteLine("1. Account " + account1.AccountNumber + " (" + account1.HolderName + ")");
                Console.WriteLine("2. Account " + account2.AccountNumber + " (" + account2.HolderName + ")");
                int pick = GetIntInput("Choose an account (1 or 2): ");

                if (pick == 1)
                {
                    return account1;
                }
                else if (pick == 2)
                {
                    return account2;
                }
                else
                {
                    Console.WriteLine("Invalid pick");
                    return account1;
                }
            }

            static Student ChooseStudent(Student student1, Student student2)
            {
                Console.WriteLine("1. Student " + student1.Name);
                Console.WriteLine("2. Student " + student2.Name);
                int pick = GetIntInput("Choose a student (1 or 2): ");

                if (pick == 1)
                {
                    return student1;
                }
                else if (pick == 2)
                {
                    return student2;
                }
                else
                {
                    Console.WriteLine("Invalid pick");
                    return student1;
                }
            }

            static Product ChooseProduct(Product product1, Product product2)
            {
                Console.WriteLine("1. " + product1.ProductName);
                Console.WriteLine("2. " + product2.ProductName);
                int pick = GetIntInput("Choose a product (1 or 2): ");

                if (pick == 1)
                {
                    return product1;
                }
                else if (pick == 2)
                {
                    return product2;
                }
                else
                {
                    Console.WriteLine("Invalid pick");
                    return product1;
                }
            }

            //Case 1 - View Account Details
            static void Case1ViewAccountDetails(BankAccount account1, BankAccount account2)
            {
                BankAccount chose = ChooseAccount(account1, account2);
                chose.CheckBalance();
            }

            //Case 2 - Update Student Address
            static void Case2UpdateStudentAddress(Student st1,  Student st2)
            {
                Student chose = ChooseStudent(st1, st2);
                string newAdds = GetStringInput("Enter new address: ");
                chose.Address = newAdds;
                Console.WriteLine("Addres updated. The new addres for "+chose.Name+"is: "+chose.Address);

            }

            //Case 3 - Make a Deposit
            static void Case3MakeDeposit(BankAccount acc1,  BankAccount acc2)
            {
                BankAccount chose = ChooseAccount(acc1 , acc2) ;
                double amount = GetDoubleInput("Enter deposet amount: ");
                chose.Deposit(amount);
                Console.WriteLine(chose.HolderName + " updated balance: " + chose.Balance);

            }

            //Case 4 - Make a Withdrawal
            static void Case4MakeWithdrawal(BankAccount acc1, BankAccount acc2) 
            {
                BankAccount chose = ChooseAccount(acc1, acc2);
                double amount = GetDoubleInput("Enter withdrawal amount: ");
                chose.Withdraw(amount);
                Console.WriteLine("Updated balance: " + chose.Balance);
            }

            //Case 5 - View Product Details
            static void Case5ViewProductDetails(Product product1, Product product2)
            {
                Product chose = ChooseProduct(product1, product2);
                double val = chose.GetInventoryValue();
                Console.WriteLine("total invatory value: " + val);
            }



        }
    }
}
    
    

