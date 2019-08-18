using System.Collections.Generic;

namespace UnitTests
{
    public class LogMock : ILog
    {
        private bool expectedResult;
        public Dictionary<string, int> MethodCallCount;

        public LogMock(bool expectedResult)
        {
            this.expectedResult = expectedResult;
            MethodCallCount = new Dictionary<string, int>();
        }
        
        private  void AddOrIncrement(string methodName)
        {
            if (MethodCallCount.ContainsKey(methodName))
            {
                MethodCallCount[methodName]++;
            }
            else
            {
                MethodCallCount.Add(methodName,1);
            }
        }

        public bool Write(string msg)
        {
            AddOrIncrement(nameof(Write));
            return expectedResult;
        }
    }
}