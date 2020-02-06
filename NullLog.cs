namespace UnitTests
{
    public  class NullLog : ILog
    {
        /// <summary>
        /// ++++++++
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public bool Write(string msg)
        {
            return true;
        }
    }
}