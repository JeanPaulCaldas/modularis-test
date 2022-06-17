using ModularisTest.Domain.Repositories;
using System;

namespace ModularisTest.Infrastructure.DataSources
{
    internal class ConsoleSource : ILogSource
    {
        public void Log(Message message)
        {
            Console.ForegroundColor = message.Type.GetConsoleColor();
            Console.WriteLine(message);
        }
    }
}
