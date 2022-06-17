using System;

namespace ModularisTest.Infrastructure
{
    internal static class Extensions
    {
        internal static ConsoleColor GetConsoleColor(this MessageType type)
        {
            switch (type)
            {
                case MessageType.Warning:
                    return ConsoleColor.Yellow;
                case MessageType.Error:
                    return ConsoleColor.Red;
                case MessageType.Message:
                default:
                    return ConsoleColor.White;
            }
        }
    }
}
