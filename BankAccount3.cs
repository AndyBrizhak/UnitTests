namespace UnitTests
{
    public class BankAccount3
    {
        public int Balance { get; set; }
                private readonly ILog log;
        
                public BankAccount3(ILog log)
                {
                    this.log = log;
                }
        
                public void Deposit(int amount)
                {
                    if (log.Write($"Depositing {amount}"))
                    {
                        
                        Balance += amount;
                    }
                }
    }
}