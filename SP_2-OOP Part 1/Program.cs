namespace SP_2_OOP_Part_1
{
    internal class Program
    {
        class BankAccount
        {

            public int AccountNumber;
            public string HolderName;
            public double Balance;

            public BankAccount(int accountNumber, string holderName, double balance)
            {
                AccountNumber = accountNumber;
                HolderName = holderName;
                Balance = balance;
            }

            // Case 18
            public bool IsOverdrawn
            {
                get { return Balance < 0; }
            }

            public BankAccount()
            {
            }
            

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

            // Case 17
            private static int studentCount = 0;

            public Student(string name, string address, int grade)
            {
                Name = name;
                Address = address;
                Grade = grade;
                studentCount = studentCount + 1;
            }
            public static int GetStudentCount()
            {
                return studentCount;
            }

            // Case 19
            private int pin;
            public int Pin
            {
                set { pin = value; }
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



        class Program
        {
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
                static void Case2UpdateStudentAddress(Student st1, Student st2)
                {
                    Student chose = ChooseStudent(st1, st2);
                    string newAdds = GetStringInput("Enter new address: ");
                    chose.Address = newAdds;
                    Console.WriteLine("Addres updated. The new addres for " + chose.Name + "is: " + chose.Address);

                }

                //Case 3 - Make a Deposit
                static void Case3MakeDeposit(BankAccount acc1, BankAccount acc2)
                {
                    BankAccount chose = ChooseAccount(acc1, acc2);
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

                //Case 6 - Register a Student
                static void Case6RegisterStudent(Student s1, Student s2)
                {
                    Student chose = ChooseStudent(s1, s2);
                    string em = GetStringInput("Enter an emai to register: ");
                    chose.Register(em);
                    Console.WriteLine(chose.Name + " has registered successfully");
                }

                //Case 7 - Compare Two Account Balances
                static void Case7CompareBalances(BankAccount account1, BankAccount account2)
                {
                    if (account1.Balance > account2.Balance)
                    {
                        Console.WriteLine(account1.HolderName + " holds more money");
                    }
                    else if (account2.Balance > account1.Balance)
                    {
                        Console.WriteLine(account2.HolderName + " holds more money");
                    }
                    else
                    {
                        Console.WriteLine("both accounts hold equal balance");
                    }
                }

                //Case 8 - Restock Product & Stock Level Check
                static void Case8RestockProduct(Product product1, Product product2)
                {
                    Product chose = ChooseProduct(product1, product2);
                    int quantity = GetIntInput("Enter quantity to restock: ");
                    chose.Restock(quantity);

                    if (chose.StockQuantity < 10)
                    {
                        Console.WriteLine("Stock level: Low");
                    }
                    else if (chose.StockQuantity <= 49)
                    {
                        Console.WriteLine("Stock level: Moderate");
                    }
                    else
                    {
                        Console.WriteLine("Stock level: Well Stocked");
                    }
                }

                //Case 9 - Transfer Between Accounts
                static void Case9TransferBetweenAccounts(BankAccount account1, BankAccount account2)
                {
                    Console.WriteLine("Choose the source account:");
                    BankAccount source = ChooseAccount(account1, account2);
                    Console.WriteLine("Choose the distnation account:");
                    BankAccount destination = ChooseAccount(account1, account2);
                    double amount = GetDoubleInput("Enter transfer amount: ");

                    if (source.Balance >= amount)
                    {
                        source.Withdraw(amount);
                        destination.Deposit(amount);
                        Console.WriteLine("Transfer successful");
                    }
                    else
                    {
                        Console.WriteLine("Transfer failed");
                    }
                }

                //Case 10 - Update Student Grade (Validated)
                static void Case10UpdateStudentGrade(Student student1, Student student2)
                {
                    Student chose = ChooseStudent(student1, student2);
                    string input = GetStringInput("Enter new grade: ");
                    int newGrade;
                    bool isNumber = int.TryParse(input, out newGrade);

                    if (!isNumber)
                    {
                        Console.WriteLine("Invalid grade no change made");
                        return;
                    }

                    if (newGrade < 0 || newGrade > 100)
                    {
                        Console.WriteLine("Invalid grade, grade must be between 0 and 100, no change made.");
                        return;
                    }

                    chose.Grade = newGrade;
                    Console.WriteLine("Grade updated successfully to " + chose.Grade);


                }

                //Case 11 - Student Report Card
                static void Case11StudentReportCard(Student std1, Student std2)
                {
                    Student chosen = ChooseStudent(std1, std2);
                    string status;
                    if (chosen.Grade >= 60)
                    {
                        status = "Pass";
                    }
                    else
                    {
                        status = "Fail";
                    }

                    Console.WriteLine("--Report Card--");
                    Console.WriteLine("Name: " + chosen.Name);
                    Console.WriteLine("Address: " + chosen.Address);
                    Console.WriteLine("Grade: " + chosen.Grade);
                    Console.WriteLine("Status: " + status);
                }

                //Case 12 - Account Health Status
                static void Case12AccountHealthStatus(BankAccount acct1, BankAccount acct2)
                {
                    BankAccount chose = ChooseAccount(acct1, acct2);

                    if (chose.Balance < 50)
                    {
                        Console.WriteLine("Status: low balance");
                    }
                    else if (chose.Balance <= 1000)
                    {
                        Console.WriteLine("Status: healthy");
                    }
                    else
                    {
                        Console.WriteLine("Status: premium");
                    }
                }

                //Case 13 - Bulk Sale With Revenue Calculation
                static void Case13BulkSale(Product prodt1, Product prodt2)
                {
                    Product chosen = ChooseProduct(prodt1, prodt2);
                    int quantity = GetIntInput("Enter quantity to sell: ");

                    if (chosen.StockQuantity < quantity)
                    {
                        int needed = quantity - chosen.StockQuantity;
                        Console.WriteLine("Not enough stock you need " + needed + " more units to fulfill order");
                        return;
                    }

                    chosen.Sell(quantity);
                    double revenue = quantity * chosen.Price;
                    Console.WriteLine("Sale complete, total revenue: " + revenue);
                }

                //Case 14 - Scholarship Eligibility Check
                static void Case14ScholarshipEligibility(Student student1, Student student2, BankAccount account1, BankAccount account2)
                {
                    Console.WriteLine("Choose student to check:");
                    Student chosenStudent = ChooseStudent(student1, student2);
                    Console.WriteLine("Choose account to check:");
                    BankAccount chosenAccount = ChooseAccount(account1, account2);

                    bool gradeOk = chosenStudent.Grade >= 80;
                    bool balanceOk = chosenAccount.Balance >= 100;

                    if (gradeOk && balanceOk)
                    {
                        Console.WriteLine("eligible");
                    }
                    else if (!gradeOk && !balanceOk)
                    {
                        Console.WriteLine("Not eligible grade is below 80 and balance is below 100");
                    }
                    else if (!gradeOk)
                    {
                        Console.WriteLine("Not eligible grade is below 80");
                    }
                    else
                    {
                        Console.WriteLine("Not eligible balance is below 100");
                    }
                }

                //Case 15 - Full Balance Top-Up Flow
                static void Case15FullBalanceTopUp(BankAccount account1, BankAccount account2)
                {
                    BankAccount chosen = ChooseAccount(account1, account2);

                    if (chosen.Balance < 50)
                    {
                        double before = chosen.Balance;
                        double topUp = 100 - chosen.Balance;
                        chosen.Deposit(topUp);
                        Console.WriteLine("Balance before top-up: " + before);
                        Console.WriteLine("Balance after top-up: " + chosen.Balance);
                    }
                    else
                    {
                        Console.WriteLine("No top-up needed balance is already 50 or above");
                    }
                }

                //Case 16 - Quick Account Opening [Parameterized Constructor]
                static void Case16QuickAccountOpening()
                {
                    int accountNumber = GetIntInput("Enter new account number: ");
                    string holderName = GetStringInput("Enter holder name: ");
                    double startingBalance = GetDoubleInput("Enter starting balance: ");

                    BankAccount newAccount = new BankAccount(accountNumber, holderName, startingBalance);
                    Console.WriteLine("New account created");
                    newAccount.CheckBalance();
                }

                //Case 17 - Total Students Counter [Static Fields & Methods]
                static void Case17TotalStudentsCounter()
                {
                    int total = Student.GetStudentCount();
                    Console.WriteLine("Total students created: " + total);
                }

                //Case 18 - Overdrawn Account Check [Read-Only Property]
                static void Case18OverdrawnAccountCheck(BankAccount acct1, BankAccount acct2)
                {
                    BankAccount chosen = ChooseAccount(acct1, acct2);
                    if (chosen.IsOverdrawn)
                    {
                        Console.WriteLine("This account is currently overdrawn");
                    }
                    else
                    {
                        Console.WriteLine("This account is not overdrawn");
                    }
                }

                //Case 19 - Set Student Security PIN [Write-Only Property]
                static void Case19SetStudentPin(Student std1, Student std2)
                {
                    Student chosen = ChooseStudent(std1, std2);
                    int newPin = GetIntInput("Enter a 4 digit pin: ");

                    if (newPin < 1000 || newPin > 9999)
                    {
                        Console.WriteLine("Invalid pin must be exactly 4 digits");
                        return;
                    }

                    chosen.Pin = newPin;
                    Console.WriteLine("PIN set successfully for " + chosen.Name);
                }
            }

        }
    }
}
    
    

