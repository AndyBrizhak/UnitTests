using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class DataDrivenTests
    {
        private BankAccount ba;
        
        
        [SetUp]
        public void SetUp()
        {
            ba = new BankAccount(100);
        }
        [Test()]
        [TestCase(50, true, 50)]
        [TestCase(100,true,0)]
        [TestCase(1000,false,100)]
        public void TestMultipleWithdrawalScenarios(int amountToWithdraw,
            bool shouldSucced, int expectedBalance)
            {
                 var result = ba.Withdraw(amountToWithdraw);
                    Assert.Multiple(() =>
                    {
                        Assert.That(result, Is.EqualTo(shouldSucced));
                        Assert.That(expectedBalance, Is.EqualTo(ba.Balance));
                    });
            }

    }
}