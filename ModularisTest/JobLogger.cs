using ModularisTest.Domain.Exceptions;
using ModularisTest.Domain.Repositories;
using ModularisTest.Domain.Strategy;
using ModularisTest.Infrastructure.DataSources;
using System;

namespace ModularisTest
{
    public class JobLogger
    {
        private static JobLogger instance;

        private static readonly object _lock = new object();

        private readonly LogRepository repository;

        private JobLogger()
        {
            this.repository = new LogRepository(new LogContext());
        }

        public static JobLogger Instance()
        {
            if (instance == null)
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new JobLogger();
                    }
                }
            }

            return instance;
        }

        public void LogMessage(Message message, LogDestination[] destinations)
        {
            if (message is null || destinations is null || destinations.Length < 1)
            {
                throw new NoValidArgsException();
            }

            foreach (var destination in destinations)
            {
                ILogStrategy strategy = GetStrategy(destination);
                repository.Log(message, strategy);
            }
        }

        private ILogStrategy GetStrategy(LogDestination destination)
        {
            switch (destination)
            {
                case LogDestination.Console:
                    return new ConsoleStrategy(new ConsoleSource());
                case LogDestination.TextFile:
                    return new TextFileStrategy(new FileSource());
                case LogDestination.Database:
                default:
                    throw new NotImplementedException();
            }
        }


    }
}
