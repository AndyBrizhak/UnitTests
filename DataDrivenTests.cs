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
        
        

    }
}