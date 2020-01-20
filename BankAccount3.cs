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
                    log.Write($"User has withdrawn {amount}");
                   Balance += amount;
                }
    }
}