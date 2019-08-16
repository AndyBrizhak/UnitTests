using NUnit.Framework;
namespace UnitTests
{
    [TestFixture()]
    public class BankAccountTests
    {
        [Test]
        public void BankAccountShouldIncreaseOnPositiveDeposite()
        {
            var ba = new BankAccount(100);
            ba.Deposit(100);
            Assert.That(ba.Balance, Is.EqualTo(200));
        } 
        
    }
}