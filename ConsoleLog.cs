using System;

namespace UnitTests
{
    class ConsoleLog:ILog
    {
        public bool Write(string msg)
        {
            Console.WriteLine(msg);
            return true;

        }
    }
}