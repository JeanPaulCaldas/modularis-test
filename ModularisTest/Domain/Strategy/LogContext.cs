namespace ModularisTest.Domain.Strategy
{
    internal class LogContext
    {
        private ILogStrategy _strategy;

        internal void SetStrategy(ILogStrategy strategy) => _strategy = strategy;

        internal void Log(Message message) => _strategy.Log(message);
    }
}
