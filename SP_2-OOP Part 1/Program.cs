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
            public int Grade { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            private string email {  get; set; }
            private int age { get; set; }
            
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

        
        static void Main(string[] args)
        {
            
        }
    }
}
    
    

