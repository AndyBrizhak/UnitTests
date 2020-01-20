using Moq;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class BankAccountTests3
    {
         private BankAccount3 ba;
         
         [Test]
         public void DepositTest()
         {
             var log = new Mock<ILog>();
             ba = new BankAccount3(log.Object) {Balance = 100};
             ba.Deposit(100);
             Assert.That(ba.Balance, Is.EqualTo(200));
         }
         
    }
}