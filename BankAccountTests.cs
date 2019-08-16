using NUnit.Framework;
namespace UnitTests
{
    [TestFixture()]
    public class BankAccountTests
    {
        private BankAccount ba;

        [SetUp]
        public void SetUp()
        {
           ba = new BankAccount(100); 
        }
        [Test]
        public void BankAccountShouldIncreaseOnPositiveDeposite()
        {
            
            ba.Deposit(100);
            Assert.That(ba.Balance, Is.EqualTo(200));
        }

        [Test]
        public void MyMethod()
        {
            ba.Withdraw(100);
            Assert.Multiple(() =>
            {
                Assert.That(ba.Balance, Is.EqualTo(0));
                Assert.That(ba.Balance, Is.LessThan(1));
            });
        }
    }
}