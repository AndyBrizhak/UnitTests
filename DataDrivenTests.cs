using NUnit.Framework;

namespace UnitTests
{
    public class DataDrivenTests
    {
        private BankAccount ba;
        
        
        [SetUp]
        public void SetUp()
        {
            ba = new BankAccount(100);
        }

public void TestMultipleWithdrawalScenarios(int amountToWithdraw,
    bool shouldSucced,
    int expectedBalance)
{
    var result = ba.Withdraw(amountToWithdraw);
    
}

    }
}