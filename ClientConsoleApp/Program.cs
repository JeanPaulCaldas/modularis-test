using ModularisTest;
using System;

namespace ClientConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var destinations = new LogDestination[] { LogDestination.Console, LogDestination.TextFile };

            var messageM = new Message("Test Message", MessageType.Message);
            var messageW = new Message("Test Warning", MessageType.Warning);
            var messageE = new Message("Test Error", MessageType.Error);
            JobLogger jobLog = JobLogger.Instance();

            jobLog.LogMessage(messageM, destinations);
            jobLog.LogMessage(messageW, destinations);
            jobLog.LogMessage(messageE, destinations);

            Console.Read();
        }
    }
}
