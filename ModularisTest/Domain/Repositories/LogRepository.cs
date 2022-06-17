using ModularisTest.Domain.Strategy;

namespace ModularisTest.Domain.Repositories
{
    internal class LogRepository
    {
        private readonly LogContext context;

        public LogRepository(LogContext context)
        {
            this.context = context;
        }

        public void Log(Message message, ILogStrategy strategy)
        {
            context.SetStrategy(strategy);
            context.Log(message);
        }
    }
}
