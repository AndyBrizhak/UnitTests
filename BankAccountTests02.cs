using NUnit.Framework;


namespace UnitTests
{
    [TestFixture]
    public class BankAccountTests02
    {
        private BankAccount02 ba;
        
        [Test]
        public void DepositIntegrationTest()
        {
            ba = new BankAccount02(new ConsoleLog()) {Balance = 100};
            ba.Deposit(100);
            Assert.That(ba.Balance, Is.EqualTo(200));
        }
        
        [Test]
        public void DepositTestFake()
        {
            ba = new BankAccount02(new NullLog()) {Balance = 100};
            ba.Deposit(100);
            Assert.That(ba.Balance, Is.EqualTo(200)); 
        }
        
        [Test]
        public void DepositTestWithDynamicFake()
        {
            ba = new BankAccount02(Null<ILog>.Instance) {Balance = 100};
            ba.Deposit(100);
            Assert.That(ba.Balance, Is.EqualTo(200)); 
        }
    }
}