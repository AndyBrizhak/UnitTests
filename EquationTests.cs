using System;
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
        
        [Test]
                public void Test2()
                {
                    Assert.Throws<Exception>(() =>
                    {
                        Solve.Quadratic(1, 1, 1);
                    });
                } 
    }
}