using ModularisTest.Domain.Repositories;

namespace ModularisTest.Domain.Strategy
{
    internal class ConsoleStrategy : ILogStrategy
    {
        private readonly ILogSource _logger;

        public ConsoleStrategy(ILogSource log)
        {
            _logger = log;
        }

        public void Log(Message message) => _logger.Log(message);
    }
}
