using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class EquationTests
    {
        [Test]
        public void Test()
        {
            var result = Solve.Quadratic(1, 10, 16);
        } 
    }
}