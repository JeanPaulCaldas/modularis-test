using ModularisTest.Domain.Repositories;

namespace ModularisTest.Domain.Strategy
{
    internal class TextFileStrategy : ILogStrategy
    {
        private readonly ILogSource _logger;

        public TextFileStrategy(ILogSource log)
        {
            _logger = log;
        }

        public void Log(Message message) => _logger.Log(message);
    }
}
