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
                Console.WriteLine("Email sent to " + HolderName + ".");
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
    
    

