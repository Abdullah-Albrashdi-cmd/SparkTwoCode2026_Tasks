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
                Console.WriteLine("10. Update Student Grade (Validated)");
                Console.WriteLine("11. Student Report Card");
                Console.WriteLine("12. Account Health Status");
                Console.WriteLine("13. Bulk Sale With Revenue Calculation");
                Console.WriteLine("14. Scholarship Eligibility Check");
                Console.WriteLine("15. Full Balance Top-Up Flow");
                Console.WriteLine("16. Quick Account Opening (Parameterized Constructor)");
                Console.WriteLine("17. Total Students Counter (Static)");
                Console.WriteLine("18. Overdrawn Account Check (Read-Only Property)");
                Console.WriteLine("19. Set Student Security PIN (Write-Only Property)");
                Console.WriteLine("20. Exit");
                Console.WriteLine("----------------------------------------------------");
            }


            //Case 1 - View Account Details


        }
    }
}
    
    

