namespace UnitTests
{
    public class NullLogWithResult : ILog
    {
        private bool expectedResult;

        public NullLogWithResult(bool expectedResult)
        {
            this.expectedResult = expectedResult;
        }

        public bool Write(string msg)
        {
            return expectedResult;
        }
    }
}