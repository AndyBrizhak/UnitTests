using System;

namespace UnitTests
{
    class ConsoleLog:ILog
    {
        public void Write(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}