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



        }
    }
}
    
    

