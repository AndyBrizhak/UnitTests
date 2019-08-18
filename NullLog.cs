namespace UnitTests
{
    public  class NullLog : ILog
    {
        public bool Write(string msg)
        {
            return true;
        }
    }
}