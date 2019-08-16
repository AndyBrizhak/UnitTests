using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class MyFixture
    {
        [Test]
        public void Warnings()
        {
            Warn.If(2+2!=5);
            Warn.If(2+2,Is.Not.EqualTo(5));
        }
    }
}